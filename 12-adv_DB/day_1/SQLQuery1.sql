
create type loc from nchar(2) not null;

create table Department
(
	DeptNo varchar(4) primary key,
	DeptName varchar(10),
	Location_ loc,
);

create rule r1 as @x in ('NY','DS','KW');
sp_bindrule r1,loc;

create default def1 as 'NY';
sp_bindrule r1,loc;

insert into Department
values('d1','Reseach','NY');

insert into Department
values('d2','Accounting','DS');

insert into Department
values('d3','Markiting','KW');


create table Employee
(
	EmpNo int,
	EmpFname varchar(10) not null , 
	EmpLname varchar(10) not null,
	DeptNo_ varchar(4),
	Salary int,
	constraint c1 primary key(EmpNo),
	constraint c2 foreign key(DeptNo_) references Department(DeptNo),
	constraint c3 unique(Salary),
)

create rule r2 as @x<6000;
sp_bindrule r2,'Employee.Salary';

insert into Works_on
values(11111 ,'p2','Analyst','2007-10-15')

update Works_on
set Works_on.empno = 11111  
where Works_on.empno = 10102  

update Human_Resource.Employee
set Human_Resource.Employee.empno = 22222  
where Human_Resource.Employee.empno = 10102   

delete from Human_Resource.Employee
where Human_Resource.Employee.EmpNo = 10102


alter table Employee add TelephoneNumber varchar(11)




ALTER TABLE Employee     
DROP COLUMN TelephoneNumber;



create schema Company;
alter schema Company transfer Department ;
alter schema Company transfer Project ;

create schema Human_Resource;
alter schema Human_Resource transfer Company.Employee;


select * from sys.sysconstraints
where id = (select object_id from sys.tables where name = 'Employee')

--sys.systemconstraints
create synonym Emp
for Human_Resource.Employee;

Select * from Employee
Select * from Human_Resource.Employee
Select * from Emp
Select * from Human_Resource.Emp;


--5.	Increase the budget of the project where the manager number is 10102 by 10%.

UPDATE p
SET p.budget += (p.budget * .1)  
FROM company.Project AS p
INNER JOIN works_on  AS w 
       ON p.projectNO = w.projectNO
WHERE w.EmpNo = 10102 
  AND w.Job = 'Manager';

--6.	Change the name of the department for which the employee named James works.The new department name is Sales.

UPDATE d
SET d.DeptName = 'Sales'
FROM company.Department AS d
INNER JOIN Human_Resource.Employee  AS e 
       ON d.DeptNo = e.DeptNo_
WHERE e.EmpFname = 'James' 

--7.	Change the enter date for the projects for those employees who work in project p1 and belong to department ‘Sales’. The new date is 12.12.2007.

UPDATE w
SET w.Enter_Date = '12.12.2007'
FROM Works_on AS w
INNER JOIN Human_Resource.Employee  AS e 
       ON w.EmpNo = e.EmpNo
INNER JOIN Company.Department AS d
	   ON e.DeptNo_ =  d.DeptNo
WHERE d.DeptName = 'sales' AND w.ProjectNo ='p1' 


--8.	Delete the information in the works_on table for all employees who work for the department located in KW.

delete from w
FROM Works_on AS w
INNER JOIN Human_Resource.Employee  AS e 
       ON w.EmpNo = e.EmpNo
INNER JOIN Company.Department AS d
	   ON e.DeptNo_ =  d.DeptNo
WHERE d.Location_ = 'KW'




