use master 
go

drop database DB_XC
go
create database DB_XC
go

use DB_XC
go

--采购订单表
drop table purchaseOrder
go
create table purchaseOrder
(
	internalOrderNumber nvarchar(30),--内部订单号
	officialOrderNumber nvarchar(50),--正式订单号
	operatorID nvarchar(20),		 --操作员编号
	customerID int,					 --客户编号
	arrivalTime datetime,			 --预计到货时间
	creationTime datetime,			 --创建时间
	auditStatus bit,				 --经理审核状态
	completeState bit,				 --订单完成状态
)
go

--采购货物表
drop table purchaseGoods
go
create table purchaseGoods
(
	purchaseID int identity(1,1),		  --采购编号
	internalOrderNumber nvarchar(30),	  --内部订单
	productID nvarchar(30),				  --产品编号
	supportingProducts bit,				  --是否含有配套产品
	supplierNumber int,					  --供应商编号
	purchaseQuantity int,				  --采购数量
	invoice bit,						  --是否附有发票
	purchaseRemark nvarchar(100),		  --备注
)
go

--入库表
drop table warehousing
go
create table warehousing
(
	purchaseID int,							   --采购编号
	internalOrderNumber nvarchar(30),		   --内部订单号
	receiptExpressNumber nvarchar(50),		   --收货快递单号
	receiptExpressCompany nvarchar(20),		   --收货快递公司
	productionPosition nvarchar(20),		   --仓位
	supplierRelevantNumber nvarchar(50),	   --供应商相关编号
	storageDate datetime,					   --入库日期
	CollectionQuantity int,					   --实收数量
	wareOperatorID nvarchar(20),			   --操作员编号
	invoiceNumber nvarchar(50),				   --发票号码
	wareRemark nvarchar(100),				   --备注
	wareState bit,							   --完成状态
)
go

--序列号表
drop table serial
go
create table serial
(
	serialNumber int identity(1,1),		--序列编号
	productID nvarchar(30),				--产品编号
	SNCode nvarchar(30),				--S/N码
	sell bit,							--是否售出
	entryTime datetime,					--录入时间
	sellingTime datetime,				--售出时间
	serielOperatorID nvarchar(20),		--操作员编号
)
go

--库存表
drop table stock
go
create table stock
(
	inventoryNumber nvarchar(30),	--库存编号
	productID nvarchar(30),			--产品编号
	productName nvarchar(20),		--产品名称
	model nvarchar(50),				--规格型号
	purchasePrice money,			--采购单价
	purchaseincludeTax bit,			--采购单价是否含税
	salesPrice money,				--销售单价
	salesincludeTax bit,			--销售单价是否含税
	unit char(2),					--单位
	inventoryQuantity int,			--库存数量
	lastWarehousing datetime,		--最后一次入库时间
	stockOperatorID nvarchar(20),	--操作员编号
)
go

--财务表
drop table finance
go
create table finance
(
	financialNumber nvarchar(30),		  --财务编号
	internalOrderNumber nvarchar(30),	  --内部订单号
	paymentDate datetime,				  --财务付款日期
	paymentAmount money,				  --付款金额
	paymentRemark nvarchar(100),		  --备注
	financeOperatorID nvarchar(20),		  --操作员编号
)
go

--出库表
drop table outgoing
go
create table outgoing
(
	outgoingNumber int identity(1,1),			  --出库编号
	officialOrderNumber nvarchar(50),			  --客户订单号（正式订单号）
	outgoingcustomerID int,						  --客户编号
	outgoingproductID nvarchar(30),				  --产品编号
	outgoingQuantity int,						  --出库数量
	outgoingDiscount float check(outgoingDiscount between 0.1 and 1), --折扣
	includeTax bit,								  --是否含税
	deliveryExpressnumber nvarchar(50),			  --发货快递单号
	deliveryExpressCompany nvarchar(20),		  --发货快递公司
	deliveryTime datetime,						  --发货时间
	outgoingOperatorID nvarchar(20),			  --操作员编号
	outgoingRemark nvarchar(100),				  --备注
	outgoingState bit,							  --完成状态
)
go
select * from userinfo
--用户信息表
drop table userinfo
go
create table userinfo
(
	userNumber int identity(1,1),		  --用户编号
	loginNumber nvarchar(20) unique,	  --登录账号
	loginPwd nvarchar(max),				  --用户密码
	userRights int,						  --用户权限
	userStatus bit,						  --用户状态
	userOperatorID nvarchar(20),		  --操作员编号
)
go

--用户隐私表（加密）
drop table userprivacy
go
create table userprivacy
(
	userNumber int,							   --用户编号
	userName nvarchar(20),					   --用户姓名
	userNativeplace nvarchar(20),			   --籍贯
	userGender bit,							   --性别
	userMarriage bit,						   --婚姻
	userNation nvarchar(20),				   --民族
	userBirth datetime,						   --出生日期
	userPolitical nvarchar(20),				   --政治面貌
	userFamilysituation nvarchar(200),		   --家庭情况
	userHomeaddress nvarchar(200),			   --家庭住址
	userContactinfo nvarchar(50),			   --联系方式
	userPhotoURL nvarchar(max),				   --个人头像URL
	userMonologue nvarchar(max),			   --个人独白
)
go

--用户权限表
drop table rights
go
create table rights
(
	rightsLevel int identity(1,1),	 --权限等级
	rightsName nvarchar(20),		 --权限名称
	rightsRemark nvarchar(100),		 --权限备注
)
go

--客户信息表
drop table customerinfo
go
create table customerinfo
(
	customerNumber int identity(1,1),						 --客户编号
	customerName nvarchar(20),								 --客户名称
	customerGender bit,										 --客户性别
	customerCompany nvarchar(50),							 --公司名称
	customerContactinfo nvarchar(20),						 --联系方式
	customerContactAddress nvarchar(100),					 --联系地址
	customerRemark nvarchar(100),							 --备注
	customerStatus bit,										 --用户状态
	customerOperatorID nvarchar(20),						 --操作员编号
)
go

--供应商表
drop table supplier
go
create table supplier
(
	supplierNumber int identity(1,1),	   --供应商编号
	supplierName nvarchar(20),			   --供应商名称
	supplierInfo nvarchar(100),			   --供应商信息
	supplierRemark nvarchar(200),		   --备注
	supplierStatus bit,					   --供应商状态
	supplierIperatorID nvarchar(20),	   --操作员编号
)
go

--维修表
drop table repair
go
create table repair
(
	repairCustomernumber int,					  --客户编号
	repairProductID nvarchar(30),				  --产品编号
	repairSNCode nvarchar(30),					  --S/N码
	repairMeg nvarchar(100),					  --维保原因
	repairName nvarchar(20),					  --维保地名称
	repairArrivalTime datetime,					  --收货日期
	repairExpressNumber nvarchar(50),			  --收货快递单号
	repairExpressCompany nvarchar(20),			  --收货快递公司名称
	repairContacts nvarchar(30),				  --联系人名称
	repairContactinfo nvarchar(20),				  --联系方式
	repairContactAddress nvarchar(100),			  --联系地址
	repairReturnTime datetime,					  --归还日期
	repairReturnExpressNumber nvarchar(50),		  --归还快递单号
	repairReturnExpressCompany nvarchar(20),	  --归还快递公司名称
	repairReturnSNCode nvarchar(30),			  --新S/N码
	repairOperatorID nvarchar(20),				  --操作人编号
	repairStatus bit,							  --完成状态
)
go

--借货表
drop table borrow
go
create table borrow
(
	borrowNumber int identity(1,1),		   --借货编号
	borrowProductID nvarchar(30),		   --产品编号
	borrowSNCode nvarchar(30),			   --S/N码
	borrowQuantity int,					   --数量
	borrower nvarchar(20),				   --借货人
	borrowOperatorID nvarchar(20),		   --操作员编号
	borrowTime datetime,				   --借出时间
	borrowReturnTime datetime,			   --归还时间
	IsReturn bit,						   --是否归还
	borrowRemark nvarchar(100),			   --备注
	borrowStatus bit,					   --完成状态
)
go

--月结表
drop table monthlyknot
go
create table monthlyknot
(
	monthlyKnotNumber int identity(1,1),	--月结编号
	monthlyKnotProductID nvarchar(30),		--产品编号
	beginmonthNumber int,					--月初数量
	monthlyInput int,						--本月入库数量
	monthlyOutput int,						--本月发出数量
	endmonthNumber int,						--月末数量
	thismonth datetime,						--当前年月
)
go