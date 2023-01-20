--1.	 Create a view that displays student full name,course name
--		 if the student has a grade more than 50. 

create view v2
as
	select s.St_Fname+' '+s.St_Lname as [Full Name],c.Crs_Name
	from student s inner join Stud_Course s_c 
		on s_c .St_Id = s.St_Id
	inner join Course c
		on s_c .Crs_Id = c.Crs_Id
	where s_c.Grade>50

select * from v2

--2.	 Create an Encrypted view that displays manager names and the topics they teach. 

alter view v1
WITH ENCRYPTION
as
	select I.Ins_Name,t.Top_Name
	from Instructor I inner join Ins_Course I_C
		on I.Ins_Id = I_C.Ins_Id
	inner join Course C
		on C.Crs_Id = I_C.Crs_Id
	inner join Topic t
		on t.Top_Id = c.Top_Id

select * from v1

--3.	Create a view that will display Instructor Name, Department Name for the ‘SD’ or ‘Java’ Department 

create view v3
as 
	select I.Ins_Name,D.Dept_Name
	from Instructor I inner join Department D
		on I.Dept_Id = D.Dept_Id
	where D.Dept_Name in ('SD','Java')

select * from v3

--Create a view “V1” that displays student data for student who lives in Alex or Cairo. 
--Note: Prevent the users to run the following query 
--Update V1 set st_address=’tanta’
--Where st_address=’alex’;


create view v4
as 
	select *
	from Student S
	where S.St_Address in ('Alex','Cairo')
with check option

select * from V4
Update V4 set st_Address='tanta'
Where st_Address='Alex'


----5.	Create a view that will display the project name and 
--      the number of employees work on it. “Use SD database”

use SD
alter view v5
as 
	select P.ProjectName,count(W.EmpNo) as [Num]
	from Company.Project P inner join Works_on W
		on P.ProjectNo = W.ProjectNo
	group by P.ProjectName 

select * from v5


--6.	Create index on column (Hiredate) that allow u to cluster the data in table Department. What will happen?

create nonclustered index i1
on Department(manager_hiredate)

--7 	Create index that allow u to enter unique ages in student table. What will happen? 

create unique index i2   ---->unique constraint + nonclustered index
on student(st_age);

--8  Using Merge statement between the following two tables [User ID, Transaction Amount]

use ITI
merge into Last_transation as t
using Daily_transation as d
on t.id=d.id
when matched then
	update 
		set t.Transaction_Amount = d.Transaction_Amount
when not matched by target then
	insert
		values(d.id,d.Transaction_Amount);

select * from Last_transation
select * from Daily_transation




