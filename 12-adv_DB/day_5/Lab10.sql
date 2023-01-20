--1.	Create a cursor for Employee table that increases Employee salary by 10%
--		if Salary <3000 and increases it by 20% if Salary >=3000. Use company DB
use SD

declare Mc1 cursor
for select h.Salary from HumanResources.Employee h
for update

declare @salary int
open Mc1
fetch Mc1 into @salary
while @@FETCH_STATUS=0
	begin  
		if @salary>=3000
			update HumanResources.Employee      
				set salary=@salary*1.20
			where current of Mc1
		else if @salary<3000
			update HumanResources.Employee 
				set salary=@salary*1.10
			where current of Mc1
		fetch Mc1 into @salary
	end
close Mc1
deallocate Mc1

--2.	Display Department name with its manager name using cursor. Use ITI DB
use ITI

declare Mc2 cursor
for select Ins_Name , Dept_Name from  Instructor i inner join Department d
	on i.Ins_Id = d.Dept_Manager
for read only

declare @insName varchar(20) , @DeptName varchar(20)
open Mc2
fetch Mc2 into @insName  , @DeptName
while @@FETCH_STATUS=0
	begin  
		Select @insName,@DeptName
		fetch Mc2 into @insName,@DeptName 
	end
close Mc2
deallocate Mc2

--3.	Try to display all students first name in one cell 
--		separated by comma. Using Cursor 

declare c1 cursor
for select distinct st_fname from student where st_fname is not null
for read only

declare @mName varchar(20),@getNames varchar(300)=''
open c1
fetch c1 into @mName     
while @@FETCH_STATUS=0
	begin
		set @getNames=CONCAT(@getNames,',',@mName)
		fetch c1 into @mName   
	end
select @getNames
close c1
deallocate c1

--7.	Create a sequence object that allow values from 1 to 10
--		without cycling in a specific column and test it.

create SEQUENCE myseq
START WITH 1
INCREMENT BY 1
MINVALUE 1
MAXVALUE 10
NO CYCLE

create TABLE Test
(ID int,
FName nvarchar(20));

INSERT into Test
VALUES (NEXT VALUE FOR myseq, 'hossam')
select * from Test