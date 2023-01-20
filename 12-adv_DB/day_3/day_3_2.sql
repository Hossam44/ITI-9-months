--1)	Create view named   “v_clerk” that will display employee#,project#, 
--		the date of hiring of all the jobs of the type 'Clerk'.
use SD
create view v_clerk
as 
	select E.EmpNo ,P.ProjectNo,W.Enter_Date
	from Human_Resource.Employee E inner join Works_on W
		on E.EmpNo = w.EmpNo
	inner join Company.Project P
		on P.ProjectNo =w.ProjectNo

select * from v_clerk


--2		Create view named  “v_without_budget” that will display all the projects data 
--		without budget

create view v_without_budget
as 
	select P.ProjectNo,P.ProjectName
	from Company.Project P

select * from v_without_budget


--3)	Create view named  “v_count “ that will display the project name and the # of jobs in it

create view v_count
as 
	select p.ProjectName,count(w.Job) as [Num Of Jops]
	from Company.Project P inner join Works_on W
		on P.ProjectNo = w.ProjectNo 
	group by p.ProjectName

select * from v_count
--4)	 Create view named ” v_project_p2” that will display the emp#  for the project# ‘p2’
--		 use the previously created view  “v_clerk”


create view v_project_p2
as
	select v.EmpNo
	from v_clerk v
	where V.projectNo = 'p2'

select * from v_project_p2

--5)	modifey the view named  “v_without_budget”  to display all DATA in project p1 and p2 

alter view v_without_budget
as 
	select *
	from Company.Project P
	where P.ProjectNo in('p1','p2')

select * from v_without_budget

--6)	Delete the views  “v_ clerk” and “v_count”
drop view v_clerk
select * from v_clerk

drop view v_count
select * from v_count


--7)	Create view that will display the emp# and emp lastname who works on dept# is ‘d2’

alter view v1
as 
	select E.EmpNo,E.EmpLname
	from Human_Resource.Employee E 
	where E.DeptNo_ = 'd2'
select * from v1


--8)	Display the employee  lastname that contains letter “J”
--		Use the previous view created in Q#7

select E.EmpLname
from v1 E
where E.EmpLname like '%J'

--9)	Create view named “v_dept” that will display the department# and department name.

create view v_dept
as 
	select D.DeptNo,D.DeptName
	from Company.Department D 

select * from v_dept

--10)	using the previous view try enter new department data where
--		dept# is ’d4’ and dept name is ‘Development’

insert into v_dept
values('d4','Development')

--11)	Create view name “v_2006_check” that will display employee#, the project #where he works and the date 
--		of joining the project which must be from the first of January and the last of December 2006.

alter view v_2006_check
as 
	select W.EmpNo,W.ProjectNo,W.Enter_Date
	from Works_on W
	where w.Enter_Date between '2006-1-1' and '2006-12-30'

select * from v_2006_check