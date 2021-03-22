create database ShopOnline
use ShopOnline
create table Account
(
	UserName nvarchar(50) primary key,
	Passw nvarchar(50) 
)
create table Category
(
	ID int primary key,
	Name nvarchar(50),
	Alias nvarchar(50),
	ParentID int,
	CreatedDate datetime,
	[Order] int,
	Status bit
)
--procedure check login
create proc [dbo].[Sp_Account_Login]
	@UserName nvarchar(50),
	@Passw nvarchar(50)
as
begin
	declare @count int
	declare @res bit
	select @count =COUNT (*) from Account where UserName=@UserName and Passw=@Passw
	if @count>0
		set @res=1
	else 
		set @res=0
	select @res
end
CREATE proc Sp_Category_ListAll
as
select * from Category where Status=1
order by [Order] asc
--insert
insert into Account values('luong','luongnd123')
insert into Category values(5,'Tv','tv',1,'04-02-2015',0,'true')
