USE [TestDatabase]
GO
/****** Object:  StoredProcedure [dbo].[TestProc]    Script Date: 7/10/2024 12:16:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[TestProc]
@Mode nvarchar(50) = null,
@Id int = null,
@CatageryName nvarchar(50)=null,
@Name nvarchar(50)=null,
@lastName nvarchar(50) = null,
@userName nvarchar(50) = null,
@dob date = null,
@email nvarchar(50) = null,
@phone int = null,
@cnic int = null,
@address nvarchar(50) = null,
@password nvarchar(50) = null,
@message nvarchar(50) = null,
@optionOne bit = null,
@optionTwo bit = null

as

if @Mode =('InsertUpdate')
begin

if exists (select * from TestTable where Id = @Id)

begin
update TestTable set
CatageryName = @CatageryName,
Name	 =	@Name	, 
lastName =	@lastName, 
userName =	@userName ,
dob		 =	@dob		, 
email	 =	@email	 ,
phone	 =	@phone	 ,
cnic     =	@cnic     ,
address  =	@address  ,
password =	@password ,
message  =	@message  ,
optionOne =  @optionOne,
optionTwo =  @optionTwo

WHERE Id = @Id



end
else
begin
set @Id = (select isnull(max(Id),0)+1 from TestTable)
Insert into TestTable (Id,CatageryName,Name  ,  lastName,userName , dob ,email  ,  phone ,  cnic , address  ,password   , message  , optionOne  ,optionTwo )

values    (@Id,@CatageryName,@Name  ,  @lastName,@userName , @dob, @email  ,  @phone ,  @cnic ,@address  ,@password   , @message  ,@optionOne  ,@optionTwo )

end

select 'Insert & Update Succesfully' as msg
end







If @Mode = 'ReadAll'
begin
select * from TestTable
end


If @Mode = 'ReadById'
begin
select * from TestTable
where Id = @Id
select 'ReadById Successfully' as msg
end


If @Mode = 'Delete'
begin
Delete from TestTable
where Id = @Id

select 'Delete Succesfully' as msg
end