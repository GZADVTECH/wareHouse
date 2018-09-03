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
	supplier nvarchar(50),--供应商名称
	supplierID nvarchar(50),--供应商订单号
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
	amount int,--数量
	unitPrice money,--采购单价
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
	paySum money--付款金额
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
	arrivalDate datetime,--收货日期
	trackingID nvarchar(50),--快递单号
	trackingName nvarchar(50),--快递公司名称
	contactsID nvarchar(20),--联系人编号
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

