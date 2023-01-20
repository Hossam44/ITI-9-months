
--1.	Create a stored procedure without parameters to show the number of students 
--		per department name.[use ITI DB] 


create proc Num_Std
as 
	select D.Dept_Name,COUNT(S.St_Id)
	from Department D inner join Student S
		on S.Dept_Id = D.Dept_Id
	group by D.Dept_Name

Num_std

use Company_SD
--2.	Create a stored procedure that will check for the # of employees in the project p1 
--		if they are more than 3 print message to the user “'The number of employees in the project p1 
--		is 3 or more'” if they are less display a message to the user “'The following employees work for 
--		the project p1'” in addition to the first name and last name of each one. [Company DB] 
create proc Num_Emp
as 
	declare @num int
	select @num = 
	(
	select count(W.ESSn)
	from Works_for W inner join Project P
	on W.Pno = P.Pnumber
	where P.Pname = 'p1'
	)
	if @num >3
		select 'The number of employees in the project p1 is 3 or more'
	else
	begin
		select 'The following employees work for the project p1',E.Fname , E.Lname
		from Employee E inner join Works_for W
		on E.SSN = W.ESSn
		inner join Project P
		on P.Pnumber = W.Pno
		where P.Pname = 'p1'
	end

Num_Emp

--3.	Create a stored procedure that will be used in case there is an old employee 
--		has left the project and a new one become instead of him. The procedure 
--		should take 3 parameters (old Emp. number, new Emp. number and the project number) 
--		and it will be used to update works_on table. [Company DB]

create proc update_work @oldEmp int, @newEmp int, @p_num int
as 
	update Works_for 
	set 
	works_for.ESSn = @newEmp,
	works_for.Pno = @p_num
	where works_for.ESSn = @oldEmp

update_work 112233 ,968574 ,500 


--4
ALTER TABLE project
ADD Budget int;

create table Audit_(
project_no nvarchar(50),
UserName nvarchar(50),
ModifiedDate Date,
Budget_Old int, 
Budget_New int
)

alter trigger do_Audit
on Project
after update
as	
	if update(Budget)
	begin
		declare @old int = (select Budget from deleted)
		declare @new int = (select Budget from inserted)
		declare @p_name nvarchar(50) = (select Pname from inserted)
		insert into Audit_
		values(@p_name,SUSER_NAME(),GETDATE(),@old,@new)
	end

update Project
set Project.Budget = 1
where Project.Pnumber=100


--5.	Create a trigger to prevent anyone from inserting a new record in the Department table [ITI DB]
--		“Print a message for user to tell him that he can’t insert a new record in that table”
use ITI
create trigger prevent_insert
on Department
instead of insert
as
	select 'Cant insert'

insert into Department(Dept_Id)
values(1)

--6.	 Create a trigger that prevents the insertion Process for Employee table in March [Company DB].

use Company_SD
create trigger prevent_insert2
on Employee
instead of insert
as
	if (FORMAT(getdate(),'MMMM') != 'March')
	begin
	insert into Employee
	select * from inserted
	end

insert into Employee(SSN)
values(1)

use ITI
--7.	Create a trigger on student table after insert to add Row in Student Audit table 
--		(Server User Name , Date, Note) where note will be “[username] Insert New Row with 
--		Key=[Key Value] in table [table name]”

create table std_Audit(
username varchar(50),
date_   date,
note varchar(100)
)

alter trigger t7
on student
after insert
as
	declare @key int = (select St_ID from inserted) 
	declare @user varchar(50) = SUSER_NAME()
	declare @not varchar(100) = (select @user+' Insert New Row with Key='+ convert(varchar(20),@key) + 'in table Student')
	insert into std_Audit
	values(@user,GETDATE(),@not)

insert into student(St_Id)
values(15)

--8.	 Create a trigger on student table instead of delete to add Row in Student Audit table 
--		(Server User Name, Date, Note) where note will be“ try to delete Row with Key=[Key Value]”

alter trigger t8
on student
instead of delete
as
	declare @key int = (select St_ID from deleted) 
	declare @user varchar(50) = SUSER_NAME()
	declare @not varchar(100) = (select 'try to delete Row with Key='+ convert(varchar(20),@key))
	insert into std_Audit
	values(@user,GETDATE(),@not)

delete from Student
where St_Id=2

--9.	Display all the data from the Employee table (HumanResources Schema) 
--		As an XML document “Use XML Raw”. “Use Adventure works DB” 
--		A)	Elements
--		B)	Attributes
use AdventureWorks2012

--A
select *
from HumanResources.Employee
for xml raw ('Employee'),elements

--B
select *
from HumanResources.Employee
for xml raw ('Employee')

--10.	Display Each Department Name with its instructors. “Use ITI DB”
--		A)	Use XML Auto
--		B)	Use XML Path
use ITI

--A
select D.Dept_Name,I.Ins_Name
from Department D inner join Instructor I
on D.Dept_Id = I.Dept_Id
for xml auto 

--B
select D.Dept_Name "@Department",
	   I.Ins_Id "Instructor/Ins_Id",
	   I.Ins_Name "Instructor/Ins_Name",
	   I.Salary   "Instructor/Salary"
from Department D inner join Instructor I
on D.Dept_Id = I.Dept_Id
for xml path 


--11.	Use the following variable to create a new table “customers” inside the company DB.
--		Use OpenXML


declare @docs xml ='<customers>
              <customer FirstName="Bob" Zipcode="91126">
                     <order ID="12221">Laptop</order>
              </customer>
              <customer FirstName="Judy" Zipcode="23235">
                     <order ID="12221">Workstation</order>
              </customer>
              <customer FirstName="Howard" Zipcode="20009">
                     <order ID="3331122">Laptop</order>
              </customer>
              <customer FirstName="Mary" Zipcode="12345">
                     <order ID="555555">Server</order>
              </customer>
       </customers>'

declare @Valdocs int
Exec sp_xml_preparedocument @Valdocs output, @docs
SELECT * 
FROM OPENXML (@Valdocs, '//customer')  
WITH (FirstName varchar(50) '@FirstName',
	  Zipcode int '@Zipcode', 
	  customer_order varchar(50) 'order',
	  order_id int 'order/@ID'
	  )
