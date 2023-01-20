
--1.	Retrieve number of students who have a value in their age. 

select count(S.St_Id)
From Student S
where S.St_Age is not null 

--2.	Get all instructors Names without repetition

select Distinct I.Ins_Name
from Instructor I

--3.	Display student with the following Format (use isNull function)

SELECT S.St_Id [Student ID],
	   ISNULL(S.St_Fname, 'N/A')+' '+ISNULL(S.St_Lname, '')[Student Full Name],
	   D.Dept_Name [Department name]
from Student S inner join Department D
	on S.Dept_Id = D.Dept_Id 

--4.	Display instructor Name and Department Name 
		--Note: display all the instructors if they are attached to a department or not

select I.Ins_Name,D.Dept_Name
from Instructor I left join Department D
	on I.Dept_Id = D.Dept_Id

--5.	Display student full name and the name of the course he is taking
--		For only courses which have a grade  

select S.St_Fname+' '+S.St_Lname as [Full Name] ,C.Crs_Name
from Student S inner join Stud_Course SC
	on S.St_Id = SC.St_Id
inner join Course C
	on SC.Crs_Id = C.Crs_Id
where SC.Grade is not null

--6.	Display number of courses for each topic name

SELECT COUNT(C.Top_Id) [Count]
FROM Topic T
INNER JOIN Course C
ON T.Top_Id = C.Top_Id
GROUP BY T.Top_Id;

--7.	Display max and min salary for instructors

select max(I.Salary),min(I.Salary)
from Instructor I

--8.	Display instructors who have salaries less than the average salary of all instructors.

select *
from Instructor I
where I.Salary < (select avg(Salary) from Instructor)

--9.	Display the Department name that contains the instructor
--		who receives the minimum salary.

select Top (1)D.Dept_Name
from Instructor I inner join Department D
	on I.Dept_Id = D.Dept_Id
where Salary is not null
order by I.Salary

--10.	 Select max two salaries in instructor table. 

select TOP (2) Salary
FROM Instructor I
order by Salary DESC

--11.	 Select instructor name and his salary but if there is no salary 
--		 display instructor bonus keyword. “use coalesce Function”

select I.Ins_Name,COALESCE(CONVERT(VARCHAR, Salary), 'instructor bonus')         
from Instructor I

--12.	Select Average Salary for instructors 

select avg(I.Salary)
from Instructor I

--13.	Select Student first name and the data of his supervisor

select S1.St_Fname,S2.*
from  Student S1 inner join Student S2
	on S1.St_super = S2.St_Id

--14.	Write a query to select the highest two salaries in Each Department 
--		for instructors who have salaries. “using one of Ranking Functions”
select *
From (select I.*,ROW_NUMBER() OVER(PARTITION BY I.Dept_Id ORDER BY I.Salary desc) 
		as rol from Instructor I) ss
where rol < 3

--15.	 Write a query to select a random  student from each department. 
--		 “using one of Ranking Functions

select *
From (select S.*,ROW_NUMBER() OVER(PARTITION BY S.Dept_Id 
	ORDER BY newID() desc) as rol from Student S) ss
where rol < 2 and Dept_Id is not null







