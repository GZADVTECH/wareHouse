use master
go

create database DB_wareHouse
go

use DB_wareHouse
go

--采购订单表
create table procurement
(
	autoID int identity(1,1),--自动编号
	pID nvarchar(20) primary key,--内部订单号（AVG）
	userID nvarchar(20),--采购员账号
	buyDate datetime,--采购日期
	arrivalDate datetime,--预计到货时间
	[check] bit,--经理审核签名
	isInvoice bit,--是否附有发票
)
go

--采购货物表
create table procurement_cargo
(
	autoID int identity(1,1),--自动编号
	pID nvarchar(20),--内部订单号
	productID nvarchar(50),--产品编号
	supplierID int,--供应商编号
	amount int,--数量
	unitPrice money,--采购单价
	discount float,--折扣
	totalPrices money,--采购总金额
)
go

--入库表
create table storage_cargo
(
	autoID int identity(1,1),--自动编号
	pID nvarchar(20),--内部订单号
	trackingID nvarchar(50),--快递单号
	trackingName nvarchar(50),--快递公司名称
	location nvarchar(20),--仓位
	supplierOrderID nvarchar(50),--供应商订单号
	deliveryDate datetime,--收货日期
	actualAmount int,--实收数量
	consigneeID nvarchar(20),--收货人账号
	invoiceID nvarchar(50),--发票号码
	check_taker nvarchar(20),--收发票人
	remark nvarchar(max),--备注
)
go

--序列号表
create table SNIDTable
(
	pID nvarchar(20),--内部订单号
	PNID nvarchar(50),--规格
	SNID nvarchar(50) unique--S/N号
)
go

--用户信息表
create table user_Message
(
	autoID int identity(1,1),--自动编号
	userID nvarchar(20) primary key,--用户账号
	userName nvarchar(20),--用户姓名
	userPwd nvarchar(max),--用户密码
	userLimit int--用户权限
)
go

--用户权限表
create table user_Limit
(
	autoID int identity(1,1) primary key,--自动编号
	limitName nvarchar(30)--权限名称
)
go

--财务表
create table financeTable
(
	pID nvarchar(20),--内部订单号
	payDate datetime,--财务付款日期
	paySum money,--付款金额
	remark nvarchar(max),--备注
)
go

--出库表
create table delivery_cargo
(
	autoID int identity(1,1),--自动编号
	cOrderID nvarchar(20),--客户订单号
	cID nvarchar(20),--客户编号
	productID nvarchar(50),--产品编号
	[count] int,--数量
	discount float,--折扣
	discountPrice money,--折后价
	sellingPrices money,--总金额
	trackingID nvarchar(50),--快递单号
	trackingName nvarchar(50),--快递公司名称
	arrivalDate datetime,--到货时间
	consignerID nvarchar(20),--发货人编号
	Remark nvarchar(max),--备注
)
go

--库存表
create table inventory_Table
(
	autoID int identity(1,1),--自动编号
	productID nvarchar(50) primary key,--产品编号
	productName nvarchar(50),--产品名称
	PNID nvarchar(50),--规格 
	unitPrice money,--单价
	quantity int,--库存数量
)
go

--维修表
create table maintenanceTable
(
	cID int identity(1,1),--客户编号
	productID nvarchar(50),--产品编号
	maintenanceName nvarchar(50),--维保地名称
	arrivalDate datetime,--收货日期
	trackingID nvarchar(50),--快递单号
	trackingName nvarchar(50),--快递公司名称
	contactsID nvarchar(20),--联系人编号
	returnproductID nvarchar(50),--归还产品编号
	returnDate datetime,--归还日期
	returntrackingID nvarchar(50),--归还快递单号
	returntrackingName nvarchar(50),--归还快递公司名称
)
go

--客户信息表
create table ClientTable
(
	autoID int identity(1,1) primary key,--自动编号
	cName nvarchar(20),--客户名称
	cway nvarchar(20),--联系方式
	cAddress nvarchar(max),--联系地址
)
go

--借货表
create table loanTable
(
	autoID int identity(1,1),--自动编号
	productID nvarchar(50),--产品编号
	[count] int,--数量
	salePrice money,--销售价格
	lenders nvarchar(20),--借贷人
	approverID  nvarchar(20),--审批人
	borrowDate datetime,--借出时间
	returnDate datetime,--归还时间
	isReturn bit,--是否归还
	remark nvarchar(max),--备注
)
go

--供应商表
create table supplierTable
(
	autoID int identity(1,1),--自动编号
	supperName nvarchar(50),--供应商名称
	supperMsg nvarchar(max),--供应商信息
	remark nvarchar(max),--备注
)
go

------------------------------存储过程----------------------------------------
--验证账号密码是否存在,如果存在，返回编号，姓名，权限等信息
create procedure pro_Login
@uid nvarchar(20),@pwd nvarchar(max)
as
begin
declare @count int
select @count=(select Count(*) from user_Message where userID=@uid and userPwd=@pwd)
if @count>0
begin
select userID,userName,userLimit from user_Message where userID=@uid
end
end
go
--查询添加修改客户信息
create proc pro_Client
@id int,@name nvarchar(20),@way nvarchar(20),@address nvarchar(max)
as
begin
if(@way<>'' and @address<>'')
insert into ClientTable values(@name,@way,@address)
else if(@id<>0 or @name<>'' and @way='' and @address='')
select * from ClientTable where autoID=@id or cName=@name
else if(@id=0 and @name='' and @way='' and @address='')
select * from ClientTable
end
go
-----------------------------测试数据-----------------------------------------
--插入用户权限表信息
insert into user_Limit values('超级管理员'),('采购管理员'),('财务管理员'),('仓库管理员'),('其他管理员')
go
select * from user_Limit
go

--插入超级管理员测试数据
insert into user_Message values('admin','超级管理员','88888888',1)
go
select * from user_Message
go