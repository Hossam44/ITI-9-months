Use ITI 
create function return_month(@date date)
returns varchar(20)
begin
	return DATENAME(month,@date)
end
select dbo.return_month('4-4-2000')


create function numbers_between(@first int,@second int)
returns @t table(numbers int)
as
	begin
		while @first<= @second
			begin
			insert into @t
			values(@first)

			set @first +=1
			end
		return
	end

select * from numbers_between(1,5)

--3

create function student_info(@sid int)
returns table
as
	return 
		(
		 select s.St_Fname +' '+ s.St_Lname as [Full NAme] ,d.Dept_Name
		 from Student s inner join Department d
			on s.Dept_Id = d.Dept_Id
		 where  s.St_Id= (select @sid)
		)

select * from student_info(1)


--4

alter function return_message(@sid int)
returns varchar(40)
begin
	declare @first_name varchar(20) ,@last_name varchar(20)

	select @first_name=s.St_Fname,@last_name=s.St_Lname 
	from student s
	where s.St_Id = (select @sid)

	if @first_name is null and @last_name is null 
		return 'First name & last name are null'
	else if @first_name is null
		return 'first name is null'
	else if @last_name is null
		return 'last name is null'
	else
		return 'First name & last name are not null'
	return 0
end

select dbo.return_message(15)

--5

create function manager_data(@mid int)
returns table
as
	return 
		(
		 select d.Dept_Name ,d.Dept_Manager,d.Manager_hiredate
		 from Department d
		 where  d.Dept_Id= (select @mid)
		)

select * from manager_data(10)


--6

alter function get_name(@name varchar(20))
returns @t table(your_name varchar(20))
as
	begin
		if @name = 'first name' 
		begin
			insert into @t
			select isnull(s.St_Fname,'Empty')
			from Student s
		end
		else if @name = 'last name'  
		begin
			insert into @t
			select isnull(s.St_Lname,'Empty')
			from Student s
		end
		else if @name = 'full name'   
		begin
			insert into @t
			select isnull(s.St_Fname+' '+s.St_Lname,'Empty') as [Full name]
			from Student s
		end
		return
	end

select * from get_name('full name'  )

--7

select s.St_Id,SUBSTRING(s.St_Fname,0,LEN(s.St_Fname))
from Student s

--8
delete from I
from Ins_Course as I
inner join student s
on I.Ins_Id = s.St_Id
inner join Department d
on s.Dept_Id = d.Dept_Id
where d.Dept_Name = 'SD'




