use Company_SD
select * from Employee
--select * from Departments
--select * from Dependent
select * from Project
select * from Works_for

--1.	Display the Department id, name and id and the name of its manager.
select D.Dnum as [ID Department],D.Dname as [Name Of Department], e.SSN,e.Fname+' '+e.Lname
from Departments D inner join Employee E
on E.SSN =D.MGRSSN

--2.	Display the name of the departments and the name of the projects under its control.
select D.Dname as [Name Of Department], P.Pname as [Name Of Preoject]
from Departments D inner join Project P
on  D.Dnum=P.Dnum

--3.	Display the full data about all the dependence associated with the name of the employee they depend on him/her.
select E.Fname+' '+E.Lname as [Full name],D.*
from Employee E inner join Dependent D 
on E.SSN =D.ESSN

--4.	Display the Id, name and location of the projects in Cairo or Alex city.
select p.Pnumber,p.Pname,p.Plocation
from Project p
where p.City='cairo' or p.City='Alex'   --in('cairo;','alex')

--5.	Display the Projects full data of the projects with a name starts with "a" letter.
select *
from Project p
where p.Pname like 'a%'

--6.	display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
select *
from Employee E
where e.Salary>=1000 and e.Salary<=2000

--7.	Retrieve the names of all employees in department 10 who works more than or equal10 hours per week on "AL Rabwah" project.
select E.Fname+' '+E.Lname as [Full name]
from Departments D inner join Employee E
	on D.MGRSSN = E.SSN and d.Dnum = 10
inner join 
Works_for W
	on W.ESSn = E.SSN and W.Hours >=10
inner join
Project p
	on p.Pnumber = W.Pno and P.Pname= 'AL Rabwah'

--8.	Find the names of the employees who directly supervised with Kamel Mohamed.
select E_emp.Fname+' '+E_emp.Lname as [Full name]
from Employee E_emp inner join Employee E_sup
	on E_emp.Superssn = E_sup.SSN and E_sup.Fname = 'Kamel' and E_sup.Lname='Mohamed'

--9.	Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.
select E.Fname+' '+E.Lname as [Full name],P.Pname as [Project Number]
from Employee E inner join Works_for W
	on E.SSN = W.ESSn
inner join 
Project P
	on P.Pnumber = w.Pno


--10.		For each project located in Cairo City .find the project number, the controlling department name ,the department manager last name ,address and birthdate.
select Pnumber,Dname,Lname,Address,Bdate
from Project P inner join Departments S
	on P.Dnum = S.Dnum and P.City = 'cairo'
inner join 
Employee E
	on S.MGRSSN = E.SSN

--11.	Display All Data of the managers

select *
from Employee E ,Departments D
where E.SSN = D.MGRSSN   

--12.	Display All Employees data and the data of their dependents even if they have no dependents
select *
from Employee E left outer join Dependent D
	on E.SSN = D.ESSN
	
--13.	Insert your personal data to the employee table as a new employee in department number 30, SSN = 102672, Superssn = 112233, salary=3000.
insert into Employee
values ('hossam','Metwally',102672,'4/4/2000','fayoum','M',3000,112233,30)

--14.	Insert another employee with personal data your friend as new employee in department number 30, SSN = 102660, but don’t enter any value for salary or supervisor number to him.
insert into Employee(Fname,Lname,SSN,Bdate,Address,Sex,Dno)
values ('ahmed','ali',102660,'4/4/2000','fayoum','M',30)

--15.	Upgrade your salary by 20 % of its last value.
UPDATE Employee
SET Salary+=(Salary*.2)
WHERE SSN=102672;