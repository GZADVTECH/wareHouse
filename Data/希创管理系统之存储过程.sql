--采购订单执行存储过程
drop procedure pro_execute_purchaseOrder
go
create procedure pro_execute_purchaseOrder
@internalOrderNumber nvarchar(30),		--内部订单号
@officialOrderNumber nvarchar(50)='',	--正式订单号
@operatorID nvarchar(20),				--操作员编号
@customerID int='',			   			--客户编号
@arrivalTime datetime=null,				--预计到货时间
@creationTime datetime=null,			--创建时间
@auditStatus bit=0,						--经理审核状态
@completeState bit=0,					--订单完成状态
@type int=0								--状态
as
begin
--插入
if(@type=1)
begin 
insert into purchaseOrder values(@internalOrderNumber,@officialOrderNumber,@operatorID,@customerID,@arrivalTime,@creationTime,@auditStatus,@completeState)
end
--更新
if(@type=2)
begin
if(@auditStatus<>0)
update purchaseOrder set auditStatus=@auditStatus where internalOrderNumber=@internalOrderNumber
if(@completeState<>0)
update purchaseOrder set completeState=@completeState where internalOrderNumber=@internalOrderNumber
end
--删除
if(@type=3)
delete purchaseOrder where internalOrderNumber=@internalOrderNumber
end
go

--采购货物执行存储过程
drop procedure pro_execute_purchaseGoods
go
create procedure pro_execute_purchaseGoods
@internalOrderNumber nvarchar(30),	  --内部订单
@productID nvarchar(30),			  --产品编号
@supportingProducts bit=0,			  --是否含有配套产品
@supplierNumber nvarchar(20),		  --供应商编号
@purchaseQuantity int,				  --采购数量
@invoice bit=0,						  --是否附有发票
@purchaseRemark nvarchar(100)='',	  --备注
@type int							  --类型
as
begin
--插入
if(@type=1)
begin
insert into purchaseGoods values(@internalOrderNumber,@productID,@supportingProducts,@supplierNumber,@purchaseQuantity,@invoice,@purchaseRemark)
end
--更新
if(@type=2)
begin
update purchaseGoods set supportingProducts=@supportingProducts,supplierNumber=@supplierNumber,purchaseQuantity=@purchaseQuantity,invoice=@invoice,purchaseRemark=@purchaseRemark where internalOrderNumber=@internalOrderNumber and productID=@productID
end
--删除
if(@type=3)
begin
delete purchaseGoods where internalOrderNumber=@internalOrderNumber and productID=@productID
end
end
go

--入库执行存储过程
drop procedure pro_execute_warehousing
go
create procedure pro_execute_warehousing
@purchaseID int,						         --采购编号
@internalOrderNumber nvarchar(30),				 --内部订单号
@receiptExpressNumber nvarchar(50)='',			 --收货快递单号
@receiptExpressCompany nvarchar(20)='',   		 --收货快递公司
@productionPosition nvarchar(20)='',			 --仓位
@supplierRelevantNumber nvarchar(50)='',	     --供应商相关编号
@storageDate datetime,							 --入库日期
@CollectionQuantity int,						 --实收数量
@wareOperatorID nvarchar(20),					 --操作员编号
@invoiceNumber nvarchar(50)='',					 --发票号码
@wareRemark nvarchar(100)='',					 --备注
@wareState bit=0,								 --完成状态
@type int										 --类型
as
begin
--插入
if(@type=1)
insert into warehousing values(@purchaseID,@internalOrderNumber,@receiptExpressNumber,@receiptExpressCompany,@productionPosition,@supplierRelevantNumber,@storageDate,@CollectionQuantity,@wareOperatorID,@invoiceNumber,@wareRemark,@wareState)
--更新
if(@type=2)
begin
update warehousing set receiptExpressNumber=@receiptExpressNumber,receiptExpressCompany=@receiptExpressCompany,productionPosition=@productionPosition,supplierRelevantNumber=@supplierRelevantNumber,storageDate=@storageDate
,CollectionQuantity=@CollectionQuantity,invoiceNumber=@invoiceNumber,wareRemark=@wareRemark,wareState=@wareState where purchaseID=@purchaseID and internalOrderNumber=@internalOrderNumber
end
--删除
if(@type=3)
begin
delete warehousing where purchaseID=@purchaseID and internalOrderNumber=@internalOrderNumber
end
end
go

--序列号执行存储过程
drop procedure pro_execute_serial
go
create procedure pro_execute_serial
@productID nvarchar(30),			--产品编号
@SNCode nvarchar(30),				--S/N码
@sell bit=0,						--是否售出
@entryTime datetime,				--录入时间
@sellingTime datetime,				--售出时间
@serielOperatorID nvarchar(20),		--操作员编号
@type int							--类型
as
begin
--插入
if(@type=1)
insert into serial values(@productID,@SNCode,@sell,@entryTime,@sellingTime,@serielOperatorID)
--更新
if(@type=2)
begin
update serial set sell=@sell,sellingTime=@sellingTime where productID=@productID and SNCode=@SNCode
end
--删除
if(@type=3)
delete serial where productID=@productID and SNCode=@SNCode
end
go

--库存执行存储过程
drop procedure pro_execute_stock
go
create procedure pro_execute_stock
@inventoryNumber nvarchar(30),	--库存编号
@productID nvarchar(30),		--产品编号
@productName nvarchar(20),		--产品名称
@model nvarchar(50),			--规格型号
@purchasePrice money,			--采购单价
@purchaseincludeTax bit=0,		--采购单价是否含税
@salesPrice money,				--销售单价
@salesincludeTax bit=0,			--销售单价是否含税
@unit char(2),					--单位
@inventoryQuantity int,			--库存数量
@lastWarehousing datetime,		--最后一次入库时间
@stockOperatorID nvarchar(20),	--操作员编号
@type int						--类型
as
begin
--插入
if(@type=1)
begin
insert into stock values(@inventoryNumber,@productID,@productName,@model,@purchasePrice
,@purchaseincludeTax,@salesPrice,@salesincludeTax,@unit,@inventoryQuantity,@lastWarehousing,@stockOperatorID)
end
--更新
if(@type=2)
begin
update stock set purchasePrice=@purchasePrice,purchaseincludeTax=@purchaseincludeTax,salesPrice=@salesPrice,salesincludeTax=@salesincludeTax,inventoryQuantity=@inventoryQuantity,lastWarehousing=@lastWarehousing where inventoryNumber=@inventoryNumber
end
--删除
if(@type=3)
begin
delete stock where inventoryNumber=@inventoryNumber
end
end
go

--财务执行存储过程
drop procedure pro_execute_finance
go
create procedure pro_execute_finance
@financialNumber nvarchar(30)='',		  --财务编号
@internalOrderNumber nvarchar(30)='',	  --内部订单号
@paymentDate datetime=null,				  --财务付款日期
@paymentAmount money=null,				  --付款金额
@paymentRemark nvarchar(100)='',		  --备注
@financeOperatorID nvarchar(20),	  --操作员编号
@type int							  --类型
as
begin
--插入
if(@type=1)
begin
insert into finance values(@financialNumber,@internalOrderNumber,@paymentDate,@paymentAmount,@paymentRemark,@financeOperatorID)
end
--更新
if(@type=2)
begin
update finance set paymentRemark=@paymentRemark where financialNumber=@financialNumber and internalOrderNumber=@internalOrderNumber
end
--删除
if(@type=3)
begin
delete finance where financialNumber=@financialNumber and internalOrderNumber=@internalOrderNumber
end
end
go

--出库执行存储过程
drop procedure pro_execute_outgoing
go
create procedure pro_execute_outgoing
@outgoingNumber int=0,						  --出库编号
@officialOrderNumber nvarchar(50),			  --客户订单号（正式订单号）
@outgoingcustomerID int,					  --客户编号
@outgoingproductID nvarchar(30),			  --产品编号
@outgoingQuantity int,						  --出库数量
@outgoingDiscount float=1,					  --折扣
@includeTax bit,							  --是否含税
@deliveryExpressnumber nvarchar(50),		  --发货快递单号
@deliveryExpressCompany nvarchar(20),		  --发货快递公司
@deliveryTime datetime,						  --发货时间
@outgoingOperatorID nvarchar(20),			  --操作员编号
@outgoingRemark nvarchar(100),				  --备注
@outgoingState bit=0,						  --完成状态
@type int									  --类型
as
begin
--插入
if(@type=1)
begin
insert into outgoing values(@officialOrderNumber,@outgoingcustomerID,@outgoingproductID
,@outgoingQuantity,@outgoingDiscount,@includeTax,@deliveryExpressnumber,@deliveryExpressCompany
,@deliveryTime,@outgoingOperatorID,@outgoingRemark,@outgoingState)
end
--更新
if(@type=2)
begin
update outgoing set deliveryExpressnumber=@deliveryExpressnumber,deliveryExpressCompany=@deliveryExpressCompany,deliveryTime=@deliveryTime,outgoingRemark=@outgoingRemark,outgoingState=@outgoingState where outgoingNumber=@outgoingNumber
end
--删除
if(@type=3)
begin
delete outgoing where outgoingNumber=@outgoingNumber
end
end
go

--用户信息执行存储过程
drop procedure pro_execute_userinfo
go
create procedure pro_execute_userinfo
@loginNumber nvarchar(20),			 --登录账号
@loginPwd nvarchar(max),			 --用户密码
@userName nvarchar(20)='',			 --用户姓名
@userRights int=1,					 --用户权限
@userStatus bit=1,					 --用户状态
@userOperatorID nvarchar(20)='',	 --操作员编号
@type int							 --类型
as
begin
--插入
if(@type=1)
begin
begin try
begin transaction
insert into userinfo values(@loginNumber,@loginPwd,@userRights,@userStatus,@userOperatorID)
declare @usernumber int
select @usernumber=userNumber from userinfo where loginNumber=@loginNumber
exec pro_execute_userprivacy @usernumber,@userName,@type=1
commit tran
end try
begin catch
rollback tran
end catch
end
--更新
if(@type=2)
begin
update userinfo set loginPwd=@loginPwd,userStatus=@userStatus where loginNumber=@loginNumber
end
--删除
if(@type=3)
begin
delete userinfo where loginNumber=@loginNumber
exec pro_execute_userprivacy @usernumber,@type=3
end
end
go

--用户隐私执行存储过程
drop procedure pro_execute_userprivacy
go
create procedure pro_execute_userprivacy
@userNumber int,						   --用户编号
@userName nvarchar(20)='',					   --用户姓名
@userNativeplace nvarchar(20)='',		   --籍贯
@userGender bit=0,						   --性别
@userMarriage bit=0,					   --婚姻
@userNation nvarchar(20)='',			   --民族
@userBirth datetime=null,				   --出生日期
@userPolitical nvarchar(20)='',			   --政治面貌
@userFamilysituation nvarchar(200)='',	   --家庭情况
@userHomeaddress nvarchar(200)='',		   --家庭住址
@userContactinfo nvarchar(50)='',		   --联系方式
@userPhotoURL nvarchar(max)='',			   --个人头像URL
@userMonologue nvarchar(max)='',		   --个人独白
@type int								   --类型
as
begin
--插入
if(@type=1)
begin
insert into userprivacy values(@userNumber,@userName,@userNativeplace,@userGender,@userMarriage
,@userNation,@userBirth,@userPolitical,@userFamilysituation,@userHomeaddress,@userContactinfo
,@userPhotoURL,@userMonologue)
end
--更新
if(@type=2)
begin
update userprivacy set userName=@userName,userNativeplace=@userNativeplace,userGender=@userGender
,userMarriage=@userMarriage,userNation=@userNation,userBirth=@userBirth,userPolitical=@userPolitical
,userFamilysituation=@userFamilysituation,userHomeaddress=@userHomeaddress,usercontactinfo=@userContactinfo
,userPhotoURL=@userPhotoURL,userMonologue=@userMonologue where userNumber=@userNumber
end
--删除
if(@type=3)
begin
delete userprivacy where usernumber=@userNumber
end
end
go

--用户权限执行存储过程
drop procedure pro_execute_rights
go
create procedure pro_execute_rights
@rightsLevel int=0,				 --权限等级
@rightsName nvarchar(20),		 --权限名称
@rightsRemark nvarchar(100),	 --权限备注
@type int						 --类型
as
begin
--插入
if(@type=1)
insert into rights values(@rightsName,@rightsRemark)
--更新
if(@type=2)
update rights set rightsName=@rightsName,rightsRemark=@rightsRemark where rightsLevel=@rightsLevel
--删除
if(@type=3)
delete rights where rightsLevel=@rightsLevel
end
go

--客户信息执行存储过程
drop procedure pro_execute_customerinfo
go
create procedure pro_execute_customerinfo
@customerNumber int,								 --客户编号
@customerName nvarchar(20),							 --客户名称
@customerGender bit=0,								 --客户性别
@customerCompany nvarchar(50),						 --公司名称
@customerContactinfo nvarchar(20),					 --联系方式
@customerContactAddress nvarchar(100),				 --联系地址
@customerRemark nvarchar(100),						 --备注
@customerStatus bit=1,								 --用户状态
@customerOperatorID nvarchar(20),					 --操作员编号
@type int											 --类型
as
begin
--插入
if(@type=1)
begin
insert into customerinfo values(@customerName,@customerGender,@customerCompany,@customerContactinfo
,@customerContactAddress,@customerRemark,@customerStatus,@customerOperatorID)
end
--更新
if(@type=2)
begin
update customerinfo set @customerName=@customerName,customerGender=@customerGender
,customerCompany=@customerCompany,customerContactinfo=@customerContactinfo,customerContactAddress=@customerContactAddress
,customerRemark=@customerRemark,customerStatus=@customerStatus where customerNumber=@customerNumber
end
--删除
if(@type=3)
delete customerinfo where customerNumber=@customerNumber
end
go

--供应商执行存储过程
drop procedure pro_execute_supplier
go
create procedure pro_execute_supplier
@supplierNumber int=0,				   --供应商编号
@supplierName nvarchar(20),			   --供应商名称
@supplierInfo nvarchar(100),		   --供应商信息
@supplierRemark nvarchar(200),		   --备注
@supplierStatus bit=1,				   --供应商状态
@supplierIperatorID nvarchar(20),	   --操作员编号
@type int							   --类型
as
begin
--插入
if(@type=1)
begin
insert into supplier values(@supplierName,@supplierInfo,@supplierRemark,@supplierStatus,@supplierIperatorID)
end
--更新
if(@type=2)
begin
update supplier set supplierName=@supplierName,supplierInfo=@supplierInfo,supplierRemark=@supplierRemark,supplierStatus=@supplierStatus,supplierIperatorID=@supplierIperatorID
where supplierNumber=@supplierNumber
end
--删除
if(@type=3)
delete supplier where supplierNumber=@supplierNumber
end
go

--维修执行存储过程
drop procedure pro_execute_repair
go
create procedure pro_execute_repair
@repairCustomernumber int,						  --客户编号
@repairProductID nvarchar(30),					  --产品编号
@repairSNCode nvarchar(30),						  --S/N码
@repairMeg nvarchar(100),						  --维保原因
@repairName nvarchar(20),						  --维保地名称
@repairArrivalTime datetime=null,				  --收货日期
@repairExpressNumber nvarchar(50)='',			  --收货快递单号
@repairExpressCompany nvarchar(20)='',			  --收货快递公司名称
@repairContacts nvarchar(30)='',				  --联系人名称
@repairContactinfo nvarchar(20)='',				  --联系方式
@repairContactAddress nvarchar(100)='',			  --联系地址
@repairReturnTime datetime=null,				  --归还日期
@repairReturnExpressNumber nvarchar(50)='',		  --归还快递单号
@repairReturnExpressCompany nvarchar(20)='',	  --归还快递公司名称
@repairReturnSNCode nvarchar(30)='',			  --新S/N码
@repairOperatorID nvarchar(20),					  --操作人编号
@repairStatus bit=0,							  --完成状态
@type int										  --类型
as
begin
--插入
if(@type=1)
begin
insert into repair values(@repairCustomernumber,@repairProductID,@repairSNCode
,@repairMeg,@repairName,@repairArrivalTime,@repairExpressNumber,@repairExpressCompany
,@repairContacts,@repairContactinfo,@repairContactAddress,@repairReturnTime,@repairReturnExpressNumber
,@repairReturnExpressCompany,@repairReturnSNCode,@repairOperatorID,@repairStatus)
end
--更新
if(@type=2)
begin
if(@repairExpressNumber is not null)
begin
update repair set repairArrivalTime=@repairArrivalTime,repairExpressNumber=@repairExpressNumber,repairExpressCompany=@repairExpressCompany where repairCustomernumber=@repairCustomernumber and repairProductID=@repairProductID
end
else if(@repairReturnExpressNumber is not null)
begin
update repair set repairReturnTime=@repairReturnTime,repairReturnExpressNumber=@repairReturnExpressNumber,repairReturnExpressCompany=@repairReturnExpressCompany,repairReturnSNCode=@repairReturnSNCode,repairStatus=1 where repairCustomernumber=@repairCustomernumber and repairProductID=@repairProductID
end
else
begin
update repair set repairStatus=@repairStatus where repairCustomernumber=@repairCustomernumber and repairProductID=@repairProductID
end
end
--删除
if(@type=3)
begin
delete repair where repairCustomernumber=@repairCustomernumber and repairProductID=@repairProductID
end
end
go

--借货执行存储过程
drop procedure pro_execute_borrow
go
create procedure pro_execute_borrow
@borrowNumber int,					   --借货编号
@borrowProductID nvarchar(30),		   --产品编号
@borrowSNCode nvarchar(30),			   --S/N码
@borrowQuantity int,				   --数量
@borrower nvarchar(20),				   --借货人
@borrowOperatorID nvarchar(20),		   --操作员编号
@borrowTime datetime,				   --借出时间
@borrowReturnTime datetime=null,	   --归还时间
@IsReturn bit=0,					   --是否归还
@borrowRemark nvarchar(100)='',		   --备注
@borrowStatus bit=0,				   --完成状态
@type int							   --类型
as
begin
--插入
if(@type=1)
begin
insert into borrow values(@borrowProductID,@borrowSNCode,@borrowQuantity,@borrower,@borrowOperatorID,@borrowTime,@borrowReturnTime,@IsReturn,@borrowRemark,@borrowStatus)
end
--更新
if(@type=2)
begin
update borrow set borrowReturnTime=@borrowReturnTime,IsReturn=@IsReturn,borrowRemark=@borrowRemark,borrowStatus=@borrowStatus 
where borrowNumber=@borrowNumber
end
--删除
if(@type=3)
begin
delete borrow where borrowNumber=@borrowNumber
end
end
go

--月结执行存储过程
drop procedure pro_execute_monthlyknot
go
create procedure pro_execute_monthlyknot
@monthlyKnotNumber int=0,				--月结编号
@monthlyKnotProductID nvarchar(30),		--产品编号
@beginmonthNumber int=0,				--月初数量
@monthlyInput int=0,					--本月入库数量
@monthlyOutput int=0,					--本月发出数量
@endmonthNumber int=0,					--月末数量
@thismonth datetime,					--当前年月
@type int								--类型
as
begin
--插入
if(@type=1)
begin
insert into monthlyknot values(@monthlyKnotProductID,@beginmonthNumber,@monthlyInput,@monthlyOutput,@endmonthNumber,@thismonth)
end
--更新
if(@type=2)
begin
update monthlyknot set beginmonthNumber=@beginmonthNumber,monthlyInput=@monthlyInput,monthlyOutput=@monthlyOutput,endmonthNumber=@endmonthNumber 
where monthlyKnotNumber=@monthlyKnotNumber
end
--删除
if(@type=3)
begin
delete monthlyknot where monthlyKnotNumber=@monthlyKnotNumber
end
end
go
---------------------------------------------------------------------
--关于采购订单及采购货物详细查询存储过程
drop procedure pro_search_purchaseOrder
go
create procedure pro_search_purchaseOrder
@internalOrderNumber nvarchar(30)='',@officialOrderNumber nvarchar(50)='',@beginTime datetime=null,@endTime datetime=null,@type int
as
begin
--查询全部
if(@type=1)
select * from purchaseOrder orde left join purchaseGoods good on orde.internalOrderNumber=good.internalOrderNumber
--查询某个时间段
else if(@type=2)
select orde.*,good.*,sup.supplierName ,stoc.*,privacy.userName,customer.customerCompany
from purchaseOrder orde 
left join purchaseGoods good on orde.internalOrderNumber=good.internalOrderNumber
left join supplier sup on sup.supplierNumber=good.supplierNumber
left join stock stoc on stoc.productID=good.productID
left join userinfo info on info.loginNumber=orde.operatorID
left join userprivacy privacy on info.userNumber=privacy.userNumber
left join customerinfo customer on customer.customerNumber=orde.customerID
where creationTime between @beginTime and @endTime
--通过内部订单号查询详细内容
else if(@type=3)
select orde.*,good.*,sup.supplierName,stoc.*,privacy.userName,customer.customerCompany
from purchaseOrder orde
left join purchaseGoods good on orde.internalOrderNumber=good.internalOrderNumber
left join supplier sup on sup.supplierNumber=good.supplierNumber
left join stock stoc on stoc.productID=good.productID
left join userinfo info on info.loginNumber=orde.operatorID
left join userprivacy privacy on info.userNumber=privacy.userNumber
left join customerinfo customer on customer.customerNumber=orde.customerID
where orde.internalOrderNumber=@internalOrderNumber and completeState=0
--通过正式订单号查询详细内容
else if(@type=4)
select orde.*,good.*,sup.supplierName,stoc.*,privacy.userName,customer.customerCompany
from purchaseOrder orde 
left join purchaseGoods good on orde.internalOrderNumber=good.internalOrderNumber 
left join supplier sup on sup.supplierNumber=good.supplierNumber
left join stock stoc on stoc.productID=good.productID
left join userinfo info on info.loginNumber=orde.operatorID
left join userprivacy privacy on info.userNumber=privacy.userNumber
left join customerinfo customer on customer.customerNumber=orde.customerID
where officialOrderNumber=@officialOrderNumber and completeState=0
--查询尚未审核的订单详细
else if(@type=5)
select orde.*,good.*,sup.supplierName,stoc.*,privacy.userName,customer.customerCompany
from purchaseOrder orde 
left join purchaseGoods good on orde.internalOrderNumber=good.internalOrderNumber 
left join supplier sup on sup.supplierNumber=good.supplierNumber
left join stock stoc on stoc.productID=good.productID
left join userinfo info on info.loginNumber=orde.operatorID
left join userprivacy privacy on info.userNumber=privacy.userNumber
left join customerinfo customer on customer.customerNumber=orde.customerID
where completeState=0 and auditStatus=0
--查询订单未完成的订单详细
else if(@type=6)
select orde.*,good.*,sup.supplierName,stoc.*,privacy.userName,customer.customerCompany
from purchaseOrder orde 
left join purchaseGoods good on orde.internalOrderNumber=good.internalOrderNumber 
left join supplier sup on sup.supplierNumber=good.supplierNumber
left join stock stoc on stoc.productID=good.productID
left join userinfo info on info.loginNumber=orde.operatorID
left join userprivacy privacy on info.userNumber=privacy.userNumber
left join customerinfo customer on customer.customerNumber=orde.customerID
where completeState=0
else if(@type=7)
select orde.internalOrderNumber,orde.officialOrderNumber,orde.auditStatus,orde.completeState,goods.purchaseID
,ware.receiptExpressNumber,ware.receiptExpressCompany,ware.productionPosition,ware.supplierRelevantNumber
,ware.storageDate,ware.CollectionQuantity,ware.wareOperatorID,ware.wareRemark,ware.invoiceNumber,ware.wareState
,goods.productID,stoc.productName,stoc.model,sup.supplierName,goods.purchaseQuantity,goods.invoice,orde.arrivalTime
from purchaseOrder orde
left join purchaseGoods goods on goods.internalOrderNumber=orde.internalOrderNumber
left join warehousing ware on ware.purchaseID=goods.purchaseID
left join stock stoc on stoc.productID=goods.productID
left join supplier sup on sup.supplierNumber=goods.supplierNumber
where orde.internalOrderNumber=@internalOrderNumber and completeState=0
end
go

--关于入库详细查询存储过程
drop procedure pro_search_warehousing
go
create procedure pro_search_warehousing
@purchaseID int=0,@internalOrderNumber nvarchar(30)='',@productID nvarchar(30)='',@type int
as
begin
--查询全部
if(@type=1)
select * from warehousing
--通过采购编号查询入库详细
if(@type=2)
select * from warehousing where purchaseID=@purchaseID and wareState=0
--通过内部订单号查询入库详细
if(@type=3)
select ware.*,goods.productID,goods.purchaseRemark
from warehousing ware
left join purchaseGoods goods on ware.internalOrderNumber=goods.internalOrderNumber
where goods.internalOrderNumber=@internalOrderNumber and wareState=0
end
go

--关于序列号详细查询存储过程
drop procedure pro_search_serial
go
create procedure pro_search_serial
@serialNumber int=0,@productID nvarchar(30)='',@SNCode nvarchar(30)='',@type int
as
begin
--查询全部
if(@type=1)
select * from serial
--通过序列编号查询详细
else if(@type=2)
select * from serial where serialNumber=@serialNumber
--通过产品编号查询详细
else if(@type=3)
select * from serial where productID=@productID and sell=0
--是否存在此SN号码
else if(@type=4)
select * from serial where productID=@productID and SNCode=@SNCode
end
go

--关于库存详细查询存储过程
drop procedure pro_search_stock
go
create procedure pro_search_stock
@inventoryNumber nvarchar(30)='',@productID nvarchar(30)='',@productName nvarchar(20)='',@model nvarchar(50)='',@type int
as
begin
--查询全部
if(@type=1)
select * from stock
--通过库存编号查询
else if(@type=2)
select * from stock where inventoryNumber=@inventoryNumber
--通过产品编号查询
else if(@type=3)
select * from stock where productID=@productID
--通过产品名称和规格型号查询
else if(@type=4)
select * from stock where productName=@productName and model=@model
else if(@type=5)
select productID,productName,model from stock
end
go

--关于财务详细查询存储过程
drop procedure pro_search_finance
go
create procedure pro_search_finance
@internalOrderNumber nvarchar(20)='',@type int
as
begin
--查询全部
if(@type=1)
select finance.financialNumber,orde.internalOrderNumber,orde.creationTime,sup.supplierName
,stoc.purchasePrice,good.purchaseQuantity,stoc.purchaseincludeTax,finance.paymentDate
,orde.auditStatus,stoc.productName,stoc.unit,good.purchaseQuantity,customer.customerName
,ware.storageDate,ware.CollectionQuantity,ware.invoiceNumber,ware.supplierRelevantNumber
,stoc.salesPrice,stoc.salesincludeTax,finance.paymentRemark,finance.paymentDate,finance.paymentAmount
from purchaseOrder orde
left join purchaseGoods good on orde.internalOrderNumber=good.internalOrderNumber
left join stock stoc on stoc.productID=good.productID
left join warehousing ware on ware.purchaseID=good.purchaseID
left join supplier sup on sup.supplierNumber=good.supplierNumber
left join customerinfo customer on customer.customerNumber=orde.customerID
left join finance finance on finance.financialNumber=good.internalOrderNumber
left join outgoing outgo on outgo.officialOrderNumber=orde.officialOrderNumber
--查询财务总结详细
if(@type=2)
begin
select good.purchaseID,orde.internalOrderNumber,orde.creationTime,sup.supplierName
,stoc.purchasePrice,good.purchaseQuantity,stoc.purchaseincludeTax,finance.paymentDate
,orde.auditStatus,stoc.productName,stoc.unit,good.purchaseQuantity,customer.customerName
,ware.storageDate,ware.CollectionQuantity,ware.invoiceNumber,ware.supplierRelevantNumber
,stoc.salesPrice,stoc.salesincludeTax,finance.paymentRemark,finance.paymentDate,finance.paymentAmount
from purchaseOrder orde
left join purchaseGoods good on orde.internalOrderNumber=good.internalOrderNumber
left join stock stoc on stoc.productID=good.productID
left join warehousing ware on ware.purchaseID=good.purchaseID
left join supplier sup on sup.supplierNumber=good.supplierNumber
left join customerinfo customer on customer.customerNumber=orde.customerID
left join finance finance on finance.financialNumber=good.internalOrderNumber
left join outgoing outgo on outgo.officialOrderNumber=orde.officialOrderNumber
where orde.internalOrderNumber=@internalOrderNumber
end
end
go

--关于出库详细查询存储过程
drop procedure pro_search_outgoing
go
create proc pro_search_outgoing
@officialOrderNumber nvarchar(50)
as
begin
select orde.officialOrderNumber,customer.customerNumber,customer.customerName
,stoc.productID,stoc.productName,stoc.model,stoc.inventoryQuantity,stoc.purchasePrice
,stoc.purchaseincludeTax,stoc.salesPrice,stoc.salesincludeTax,outgo.outgoingDiscount
from purchaseOrder orde
left join purchaseGoods good on orde.internalOrderNumber=good.internalOrderNumber
left join customerinfo customer on customer.customerNumber=orde.customerID
left join stock stoc on stoc.productID=good.productID
left join outgoing outgo on outgo.officialOrderNumber=orde.officialOrderNumber
where orde.officialOrderNumber=@officialOrderNumber
end
go
execute pro_search_userinfo @loginNumber='admin',@loginPwd='0000000',@type=2
--关于用户信息详细查询存储过程
drop procedure pro_search_userinfo
go
create procedure pro_search_userinfo
@userNumber int=0,@loginNumber nvarchar(20)='',@loginPwd nvarchar(max)='',@type int
as
begin
--查询全部
if(@type=1)
select uinfo.userNumber,loginNumber,userRights,userOperatorID,userStatus,privacy.userName,rights.rightsName 
from userinfo uinfo
left join userprivacy privacy on uinfo.userNumber=privacy.userNumber
left join rights rights on rights.rightsLevel=uinfo.userRights
--查询是否存在
else if(@type=2)
select loginNumber,userRights,privacy.userName from userinfo uinfo
left join userprivacy privacy on uinfo.userNumber=privacy.userNumber 
where loginNumber=@loginNumber and loginpwd=@loginPwd and userStatus=1
end
go

--关于客户信息详细查询存储过程
drop procedure pro_search_customerinfo
go
create procedure pro_search_customerinfo
@customerNumber int=0,@type int
as
begin
--查询全部
if(@type=1)
select * from customerinfo where customerStatus=1
--查询指定客户详细
if(@type=2)
select * from customerinfo where customerNumber=@customerNumber and customerStatus=1
end
go

--关于供应商详细查询存储过程
drop procedure pro_search_supplier
go
create procedure pro_search_supplier
@supplierNumber int='',@type int
as
begin
--查询全部
if(@type=1)
select * from supplier where supplierStatus=1
end
go
--关于维修详细查询存储过程
drop procedure pro_search_repair
go
create procedure pro_search_repair
@repairCustomernumber int=0,@repairProductID nvarchar(30)='',@repairSNCode nvarchar(30)='',@type int
as
begin
--查询全部
if(@type=1)
select repa.*,stoc.productName,stoc.model,customer.customerName from repair repa 
left join stock stoc on repa.repairProductID=stoc.productID
left join customerinfo customer on customer.customerNumber=repa.repairCustomernumber
where repa.repairStatus=0
--查询指定客户产品详细
else if(@type=2)
select repa.*,stoc.productName,stoc.model,customer.customerName from repair repa 
left join stock stoc on repa.repairProductID=stoc.productID
left join customerinfo customer on customer.customerNumber=repa.repairCustomernumber
where repa.repairCustomernumber=@repairCustomernumber and repa.repairProductID=@repairProductID 
and repa.repairSNCode=@repairSNCode and repa.repairStatus=0
end
go
--关于借货详细查询存储过程

--关于月结详细查询存储过程
drop procedure pro_monthlyknot
go
create procedure pro_monthlyknot
@beginTime datetime,@endTime datetime
as
begin
select stock.lastWarehousing,monthly.monthlyKnotProductID,stock.productName,stock.model,stock.purchasePrice
,stock.purchaseincludeTax,monthly.beginmonthNumber,monthly.monthlyInput,monthly.monthlyOutput,monthly.endmonthNumber
from monthlyknot monthly
left join stock stock on monthly.monthlyKnotProductID=stock.productID
where monthly.thismonth between @beginTime and @endTime
end
go
--查询未审核的详细订单资料
drop procedure pro_search_auditStatus
go
create procedure pro_search_auditStatus
as
begin
select purchase.*,goods.*,stoc.productName,stoc.model,customer.customerName,privacy.userName 
from purchaseOrder purchase
left join purchaseGoods goods on goods.internalOrderNumber=purchase.internalOrderNumber
left join stock stoc on stoc.productID=goods.productID
left join customerinfo customer on customer.customerNumber=purchase.customerID
left join userinfo info on info.loginNumber=purchase.operatorID
left join userprivacy privacy on privacy.userNumber=info.userNumber
end
go
--财务总结表数据
drop procedure pro_all_finance
go
create procedure pro_all_finance
@internalOrderNumber nvarchar(30)
as
begin
select orde.internalOrderNumber,orde.creationTime,goods.purchaseQuantity,stoc.purchasePrice,stoc.purchaseincludeTax,orde.arrivalTime,orde.auditStatus,stoc.productName
,customer.customerName,ware.storageDate,ware.CollectionQuantity,ware.invoiceNumber,orde.officialOrderNumber,stoc.salesPrice,stoc.salesincludeTax,finances.paymentRemark
,finances.paymentDate,finances.paymentAmount
from purchaseOrder orde
left join purchaseGoods goods on orde.internalOrderNumber=goods.internalOrderNumber
left join warehousing ware on orde.internalOrderNumber=ware.internalOrderNumber
left join stock  stoc on stoc.productID=goods.productID
left join finance finances on finances.internalOrderNumber=orde.internalOrderNumber
left join customerinfo customer on customer.customerNumber=orde.customerID
where orde.internalOrderNumber=@internalOrderNumber
end
go

----------------------------------触发器-----------------------------------
--入库触发月结表更新
drop trigger trig_warehousing_monthlyknot
go
create trigger trig_warehousing_monthlyknot
on warehousing
for insert,update
as
declare @Input int,@procudetNumber nvarchar(30),@monthlyIn int
set @Input=(select CollectionQuantity from inserted)
set @procudetNumber=(select goods.productID from inserted inserteds 
left join purchaseGoods goods on inserteds.purchaseID=goods.purchaseID)
set @monthlyIn=(select monthlyInput from monthlyknot)
update monthlyknot set monthlyInput=@Input+@monthlyIn where monthlyKnotProductID=@procudetNumber
go
--出库触发月结表更新
drop trigger trig_outgoing_monthlyknot
go
create trigger trig_outgoing_monthlyknot
on outgoing
for insert,update
as
declare @Output int,@procudetNumber nvarchar(30),@monthlyOut int
set @Output=(select outgoingQuantity from inserted)
set @procudetNumber=(select outgoingproductID from inserted)
set @monthlyOut=(select monthlyOutput from monthlyknot)
update monthlyknot set monthlyOutput=@monthlyOut-@Output where monthlyKnotProductID=@procudetNumber
go
--库存添加触发月结表添加
drop trigger trig_stock_monthlyknot
go
create trigger trig_stock_monthlyknot
on stock
for insert
as
declare @procudetNumber nvarchar(30),@beginNumber int,@datetime nvarchar(6)
set @procudetNumber=(select productID from inserted)
set @beginNumber=(select inventoryQuantity from inserted)
set @datetime=CONVERT(varchar(6),GETDATE(),112)
execute pro_execute_monthlyknot @monthlyKnotProductID=@procudetNumber,@beginmonthNumber=@beginNumber,@monthlyInput=0
,@monthlyOutput=0,@endmonthNumber=0,@thismonth=@datetime,@type=1
go

--入库触发更改库存
drop trigger trig_stock_warehousing
go
create trigger trig_stock_warehousing
on warehousing
for insert
as
declare @productID nvarchar(30),@CollectionQuantity int,@stockQuantity int
set @productID=(select Max(goods.productID) from inserted inser right join purchaseGoods goods on goods.purchaseID=inser.purchaseID)
set @CollectionQuantity=(select Max(CollectionQuantity) from inserted inser)
set @stockQuantity=(select Max(inventoryQuantity) from stock where productID=@productID)
update stock set inventoryQuantity=@stockQuantity-@CollectionQuantity where productID=@productID
go
--出库触发更改库存
drop trigger trig_stock_outgoing
go
create trigger trig_stock_outgoing
on outgoing
for insert
as
declare @productID nvarchar(30),@outgoingQuantity int,@stockQuantity int
set @productID=(select Max(outgoingproductID) from inserted)
set @outgoingQuantity=(select Max(outgoingQuantity) from inserted)
set @stockQuantity=(select Max(inventoryQuantity) from stock)
update stock set inventoryQuantity=@stockQuantity-@outgoingQuantity where productID=@productID
go

--当删除用户信息时同步删除用户隐私
create trigger trig_userinfo_userprivacy
on userinfo
for delete
as
declare @usernumber int
set @usernumber=(select userNumber from deleted)
delete userprivacy where userNumber=@usernumber
go