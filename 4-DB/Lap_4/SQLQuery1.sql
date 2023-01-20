
select *
from Dependent 
select *
from Employee
select *
from Departments 
select *
from Works_for
select *
from Project 


-- 1.	Display (Using Union Function)

select D.Dependent_name , D.Sex
from Employee E inner join Dependent D
	on E.SSN = D.ESSN and E.Sex = 'F'

union all

select D.Dependent_name , D.Sex
from Employee E inner join Dependent D
	on E.SSN = D.ESSN and E.Sex = 'M'

--2.	For each project, list the project name and the total hours per week 
--		(for all employees) spent on that project.

select P.Pname,SUM(W.Hours) as [sum Hours]
From Works_for W inner join Project P
	on W.pno=P.Pnumber
group by Pname

--3.	Display the data of the department which has 
--		the smallest employee ID over all employees' ID.

select D.Dnum,D.Dname,D.MGRSSN,D.[MGRStart Date],min(E.SSN)
from Departments D join Employee E
	on D.Dnum = E.Dno
where E.SSN = (select min(SSN) from Employee)
group by D.Dnum,D.Dname,D.MGRSSN,D.[MGRStart Date]


--4.	For each department, retrieve the department name and the
--		maximum, minimum and average salary of its employees.

select D.Dname,MAX(E.Salary) as [MAX],MIN(E.Salary) as [MIN],AVG(E.Salary) as [AVG]
from Departments D inner join Employee E
	on D.Dnum = E.Dno 
group by D.Dname

--5.	List the full name of all managers who have no dependents.

select *
from Employee E inner join Departments D
	on E.SSN = D.MGRSSN and E.SSN NOt in (select dd.ESSN from Dependent dd)


--6.	For each department-- if its average salary is less than the average salary of all employees
	-- display its number, name and number of its employees.

select D.Dnum,D.Dname,COUNT(e.SSN)
from Departments D inner join Employee E
	on D.Dnum = E.Dno 
group by D.Dnum,D.Dname
having AVG(E.Salary) < (select avg(salary) from Employee)

--7.	Retrieve a list of employees names and the projects names they are working on ordered 
-- by department number and within each department, ordered alphabetically by last name, first name.

select E.Fname + ' ' + E.Lname as [Full Name] , P.Pname
from Employee E inner join Departments D
	on E.Dno = D.Dnum
inner join
Project P
	on P.Dnum = D.Dnum
order by D.Dnum,E.Lname,E.Fname

--8.	Try to get the max 2 salaries using subquery
select max(E.Salary)
from Employee E
union all
select salary
from Employee E
where E.Salary = (select max(e.Salary) from Employee E  where E.Salary != (select max(salary) from Employee)
)

--9.	Get the full name of employees that is similar to any dependent name
select E.Fname+' '+E.Lname ,D.Dependent_name
from Employee E inner join Dependent D
	on E.SSN = D.ESSN and E.Fname+' '+E.Lname = D.Dependent_name

--10.	Display the employee number and name if 
	--at least one of them have dependents 
	--(use exists keyword) self-study.

select E.SSN,E.Fname+' '+E.Lname
from Employee E
WHERE EXISTS (SELECT D.ESSN FROM Dependent D WHERE D.ESSN = E.SSN);


--11.	In the department table insert new department called "DEPT IT" , 
		--with id 100, employee with SSN = 112233 as a manager for this department. 
		--The start date for this manager is '1-11-2006'

insert into Departments 
values ('DEPT IT',100,112233,'1-11-2006')

--12.	Do what is required if you know that : Mrs.Noha Mohamed(SSN=968574) 
--		moved to be the manager of the new department
--		(id = 100), and they give you(your SSN =102672) her position (Dept. 20 manager) 

--a.	First try to update her record in the department table

update Departments
set MGRSSN = 968574 
where Dnum = 100

update Employee
set Dno = 100
where SSN = 968574
--b.	Update your record to be department 20 manager.

update Departments
set MGRSSN = 102672 
where Dnum = 20

update Employee
set Dno = 20
where SSN = 102672

--c.	Update the data of employee number=102660 to be in your teamwork
--		(he will be supervised by you) (your SSN =102672)

update Employee
set Superssn = 102672 ,Dno = 20
where SSN = 102660

--13.	Unfortunately the company ended the contract with Mr. Kamel Mohamed (SSN=223344) 
--		so try to delete his data from your database in case you know that 
--		you will be temporarily in his position.
delete from Dependent where ESSN=223344
update Departments
set MGRSSN = 102672
where MGRSSN=223344

update Employee
set Superssn = 102672
where Superssn = 223344

delete from Works_for where ESSn=223344
delete from Employee where SSN=223344
 
--14.	Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30%
update Employee
set Salary+=Salary*.3
from Works_for W inner join Project P
	on W.Pno = P.Pnumber and P.Pname = 'Al Rabwah'
inner join
Employee E
	on W.ESSn = E.SSN

