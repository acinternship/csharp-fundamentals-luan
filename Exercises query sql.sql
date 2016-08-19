
--1
insert into Position (Title)
values ('Jedi Intern')
select * from Position

--2
select  Id, Name from Employee where Name like 'Rafael%'
select  Id, Name from Employee where Name like 'Fabio%'
select * from Seniority
select id, Title from Position where Title like 'Jed%'

insert into Employee (Email, Name, BuddyId, ManagerId,OfficeLocation, SeniorityId,PositionId,StartedDate)
values ('nemployee@avenuecode.com','New Employee', 41,22,'Belo Horizonte', 1, 35, GETDATE() ) 
select * from Employee where Name like 'New%'
update Employee set StartedDate = getdate() where id = 221

--4
select * from Position where title like 'IOS%'
update Employee set PositionId = 15 where id = 221
select * from Employee where Name like 'New%'

--5 
select  Id, Name from Employee where Name like 'Marcelo%'
update Employee set ManagerId = 82 where id = 221
select * from Employee where Name like 'New%'

--6
update Employee set PositionId = 1 where id = 221
delete from Position where id = 35
select * from Employee where Name like 'New%'
select * from Position

--7 resp:
-- it's not possible `cause we have other table depend on this date,
-- so i f want delete this position 
-- we get to update all other tables depend on this one. 