/*1) Create a new Position into the database.

2) Create a new Employee into the database.
This employee is a user called 'New Employee' and your e-mail is: nemployee@avenuecode.com. 
His buddy is Rafael Melo and His manager is Fabio Paula.
He dont have a Google account created yet and he is located at Belo Horizonte.
His position will gonna be senior at the position that you have created on the first question.
He started on Avenue Code yesterday.
Fill on the AssessmentId column the value 1.
He should be active on the system.

3) There was an error related to the started date of the New Employee. He started on the company today.

4) Update his position to iOS ENGINEER

5) The new employee now has a new manager: Marcelo Santos

6) Remove from the database the position that you have created on the first question.

7) Remove from the database the position IOS Manager. If you cant do this, try to understand the reason.
*/

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