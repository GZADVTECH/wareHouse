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
	clientID int,--客户编号
	buyDate datetime,--发货日期
	arrivalDate datetime,--预计到货时间
	[check] bit,--经理审核签名
)
go

--采购货物表
create table procurement_cargo
(
	autoID int identity(1,1),--自动编号
	pID nvarchar(20),--内部订单号
	productID nvarchar(50),--产品编号
	isParts bit,--是否含有配套产品
	supplierID int,--供应商编号
	amount int,--数量
	isTax bit,--是否含税
	unitPrice money,--采购单价
	discount float,--折扣
	totalPrices money,--采购总金额
	isInvoice bit,--是否附有发票
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
	productID nvarchar(50),--产品名称
	actualAmount int,--实收数量
	consigneeID nvarchar(20),--收货人账号
	invoiceID nvarchar(50),--发票号码
	checkTaker nvarchar(20),--收发票人
	remark nvarchar(max),--备注
)
go

--序列号表
create table SNIDTable
(
	productID nvarchar(50),--产品编号
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
	unit char(2),--单位
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

--供应商综合操作
create proc pro_supplier
@name nvarchar(50),@msg nvarchar(max)='',@remark nvarchar(max)='',@typeid int
as
begin
--查询数据
if(@typeid=0)
begin
if(@name='')
begin
select distinct * from supplierTable
end
else
begin
select distinct * from supplierTable where supperName=@name
end
end
--插入数据
else if(@typeid=1)
begin
insert into supplierTable values(@name,@msg,@remark)
end
--更新
else if(@typeid=2)
begin
update supplierTable set supperName=@name,supperMsg=@msg,remark=@remark where autoID=(select autoID from supplierTable where supperName=@name)
end
--删除
else if(@typeid=3)
begin
delete supplierTable where autoID=(select autoID from supplierTable where supperName=@name)
end
end
go

--采购订单综合操作
create procedure pro_procurement
@pid nvarchar(20),@userid nvarchar(20),@buydate datetime,@arrivaldate datetime,@check bit=0,@cid int,@typeid int
as
begin
--查询
if(@typeid=0)
begin
select * from procurement pro left join procurement_cargo procargo on pro.pID=procargo.pID
end
--插入
else if(@typeid=1)
begin
insert into procurement values(@pid,@userid,@cid,@buydate,@arrivaldate,@check)
end
--更新
else if(@typeid=2)
update procurement set buyDate=@buydate,arrivalDate=@arrivaldate,[check]=@check where pID=@pid
--删除
else if(@typeid=3)
delete procurement where pID=@pid
end
go

--采购产品综合操作
create proc pro_procargo
@pid nvarchar(20)='',@productID nvarchar(50)='',@isparts bit,@supplierid int=0,@amount int=0,@istax bit,@unitprice money='',@discount float=0,@isInvoice bit,@typeid int
as
begin
--查询
if(@typeid=0)
select * from procurement_cargo
else if(@typeid=1)
select * from procurement_cargo where pID=@pid
else if(@typeid=2)
select * from procurement_cargo where productID=@productID
--插入
else if(@typeid=3)
insert into procurement_cargo values(@pid,@productID,@isparts,@supplierid,@amount,@istax,@unitprice,@discount,@amount*@unitprice*@discount,@isInvoice)
--更新
else if(@typeid=4)
update procurement_cargo set isParts=@isparts,supplierID=@supplierid,amount=@amount,isTax=@istax,discount=@discount,totalPrices=@amount*@unitprice*@discount,isInvoice=@isInvoice where pid=@pid and productID=@productID
--删除
else if(@typeid=5)
delete procurement_cargo where pid=@pid and productID=@productID
end
go

--库存表综合操作
alter proc pro_inventory
@pid nvarchar(50)='',@productname nvarchar(50)='',@pnid nvarchar(50)='',@unitprice money='',@unit char(2)='',@quantity int='',@typeid int
as
begin 
--查询
if(@typeid=0)
begin
if(@productname<>'')
select distinct * from inventory_Table where productName=@productname
else if(@pid<>'')
select * from inventory_Table where productID=@pid
else
select distinct * from inventory_Table
end
--插入
else if(@typeid=1)
begin
insert into inventory_Table values(@pid,@productname,@pnid,@unitprice,@unit,@quantity)
end
--更新
else if(@typeid=2)
update inventory_Table set productName=@productname,PNID=@pnid,unitPrice=@unitprice,unit=@unit,quantity=@quantity where productID=@pid
--删除
else if(@typeid=3)
delete inventory_Table where productID=@pid
--查询产品名称
else if(@typeid=4)
select Max(productName) as productName from inventory_Table group by productName
--通过产品名称及内部订单号查询产品
else if(@typeid=5)
select * from inventory_Table where productName=@productname and PNID=@pnid
end
go

--通过编号查询订单详细信息
create proc pro_proc_inven
@pid nvarchar(20)
as
begin
select pro.pID,userm.userName,client.cName,pro.buyDate,pro.arrivalDate,inven.productID,supp.autoID,inven.productName,inven.PNID,cargo.amount,supp.supperName,cargo.discount,cargo.unitPrice,cargo.isTax,cargo.isParts,cargo.isInvoice
from procurement pro
 left join procurement_cargo cargo on cargo.pID=pro.pID
 left join inventory_Table inven on cargo.productID=inven.productID 
 left join user_Message userm on pro.userID=userm.userID 
 left join ClientTable client on pro.clientID=client.autoID 
 left join supplierTable supp on cargo.supplierID=supp.autoID 
 where pro.pID=@pid
end
go

--入库综合操作
create proc pro_cargo
@pid nvarchar(20),@tid nvarchar(50)='',@tname nvarchar(50)='',@location nvarchar(20)='',@soid nvarchar(50)='',@deliverydate datetime='',@productid nvarchar(50)=''
,@actualamount int=0,@consigneeid nvarchar(50)='',@invoiceid nvarchar(50)='',@checktaker nvarchar(20)='',@remark nvarchar(max)='',@typeid int
as
begin
--查询
if(@typeid=0)
begin
select * from storage_cargo where pID=@pid
end
--插入
else if(@typeid=1)
begin
insert into storage_cargo values(@pid,@tid,@tname,@location,@soid,@deliverydate,@productid,@actualamount,@consigneeid,@invoiceid,@checktaker,@remark)
end
--更新
else if(@typeid=2)
begin
update storage_cargo set trackingID=@tid,trackingName=@tname,location=@location,supplierOrderID=@soid,deliveryDate=@deliverydate,productID=productID,actualAmount=@actualamount
,consigneeID=@consigneeid,invoiceID=@invoiceid,checkTaker=@checktaker,remark=@remark where pID=@pid
end
else if(@typeid=3)
begin
delete storage_cargo where pid=@pid
end
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
--采购订单报表数据
select pro.pID,client.cName,inv.productName,inv.PNID,inv.unit,cargo.amount,inv.unitPrice,pro.buyDate,pro.arrivalDate,cargo.isTax,cargo.isParts from procurement pro left join procurement_cargo cargo on pro.pID=cargo.pID left join inventory_Table inv on cargo.productID=inv.productID left join ClientTable client on pro.clientID=client.autoID
--收货通知单报表数据
select usemes.userName,pro.pID,supp.supperName,pro.arrivalDate,inven.productName,inven.PNID,cargo.amount,cargo.isInvoice from procurement pro 
left join procurement_cargo cargo on pro.pID=cargo.pID
left join inventory_Table inven on cargo.productID=inven.productID
left join supplierTable supp on cargo.supplierID=supp.autoID
left join user_Message usemes on usemes.userID=pro.userID


---------------------------不保存测试数据---------------------------------
insert into procurement values('AVG1809061334','admin','2018/9/6','2018/9/6',0,1)
insert into inventory_Table values('00001','打印机','SN154',1200,'台',3),('00002','打印机','SL1130',1000,'台',1),('00003','打印头','1255',12000,'台',0),('00004','色带','110mm',120,'卷',10)
insert into procurement_cargo values('AVG1809061334','00001','1',2,1300,0,2600)
insert into procurement_cargo values('AVG1809061334','00002','1',1,1300,0,2600)

select * from inventory_Table

select * from inventory_Table where productID='ATY59764'

select pro.pID,client.cName,inv.productName,inv.PNID,inv.unit,cargo.amount,inv.unitPrice,pro.arrivalDate from procurement pro left join procurement_cargo cargo on pro.pID=cargo.pID left join inventory_Table inv on cargo.productID=inv.productID left join ClientTable client on pro.clientID=client.autoID

select pro.*,inv.*,cargo.*,client.* from procurement pro left join procurement_cargo cargo on pro.pID=cargo.pID left join inventory_Table inv on cargo.productID=inv.productID left join ClientTable client on pro.clientID=client.autoID
