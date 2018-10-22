--�ɹ�����ִ�д洢����
drop procedure pro_execute_purchaseOrder
go
create procedure pro_execute_purchaseOrder
@internalOrderNumber nvarchar(30),		--�ڲ�������
@officialOrderNumber nvarchar(50)='',	--��ʽ������
@operatorID nvarchar(20),				--����Ա���
@customerID int='',			   			--�ͻ����
@arrivalTime datetime=null,				--Ԥ�Ƶ���ʱ��
@creationTime datetime=null,			--����ʱ��
@auditStatus bit=0,						--�������״̬
@completeState bit=0,					--�������״̬
@type int=0								--״̬
as
begin
--����
if(@type=1)
begin 
insert into purchaseOrder values(@internalOrderNumber,@officialOrderNumber,@operatorID,@customerID,@arrivalTime,@creationTime,@auditStatus,@completeState)
end
--����
if(@type=2)
begin
if(@auditStatus<>0)
update purchaseOrder set auditStatus=@auditStatus where internalOrderNumber=@internalOrderNumber
if(@completeState<>0)
update purchaseOrder set completeState=@completeState where internalOrderNumber=@internalOrderNumber
end
--ɾ��
if(@type=3)
delete purchaseOrder where internalOrderNumber=@internalOrderNumber
end
go

--�ɹ�����ִ�д洢����
drop procedure pro_execute_purchaseGoods
go
create procedure pro_execute_purchaseGoods
@internalOrderNumber nvarchar(30),	  --�ڲ�����
@productID nvarchar(30),			  --��Ʒ���
@supportingProducts bit=0,			  --�Ƿ������ײ�Ʒ
@supplierNumber nvarchar(20),		  --��Ӧ�̱��
@purchaseQuantity int,				  --�ɹ�����
@invoice bit=0,						  --�Ƿ��з�Ʊ
@purchaseRemark nvarchar(100)='',	  --��ע
@type int							  --����
as
begin
--����
if(@type=1)
begin
insert into purchaseGoods values(@internalOrderNumber,@productID,@supportingProducts,@supplierNumber,@purchaseQuantity,@invoice,@purchaseRemark)
end
--����
if(@type=2)
begin
update purchaseGoods set supportingProducts=@supportingProducts,supplierNumber=@supplierNumber,purchaseQuantity=@purchaseQuantity,invoice=@invoice,purchaseRemark=@purchaseRemark where internalOrderNumber=@internalOrderNumber and productID=@productID
end
--ɾ��
if(@type=3)
begin
delete purchaseGoods where internalOrderNumber=@internalOrderNumber and productID=@productID
end
end
go

--���ִ�д洢����
drop procedure pro_execute_warehousing
go
create procedure pro_execute_warehousing
@purchaseID int,						         --�ɹ����
@internalOrderNumber nvarchar(30),				 --�ڲ�������
@receiptExpressNumber nvarchar(50)='',			 --�ջ���ݵ���
@receiptExpressCompany nvarchar(20)='',   		 --�ջ���ݹ�˾
@productionPosition nvarchar(20)='',			 --��λ
@supplierRelevantNumber nvarchar(50)='',	     --��Ӧ����ر��
@storageDate datetime,							 --�������
@CollectionQuantity int,						 --ʵ������
@wareOperatorID nvarchar(20),					 --����Ա���
@invoiceNumber nvarchar(50)='',					 --��Ʊ����
@wareRemark nvarchar(100)='',					 --��ע
@wareState bit=0,								 --���״̬
@type int										 --����
as
begin
--����
if(@type=1)
insert into warehousing values(@purchaseID,@internalOrderNumber,@receiptExpressNumber,@receiptExpressCompany,@productionPosition,@supplierRelevantNumber,@storageDate,@CollectionQuantity,@wareOperatorID,@invoiceNumber,@wareRemark,@wareState)
--����
if(@type=2)
begin
update warehousing set receiptExpressNumber=@receiptExpressNumber,receiptExpressCompany=@receiptExpressCompany,productionPosition=@productionPosition,supplierRelevantNumber=@supplierRelevantNumber,storageDate=@storageDate
,CollectionQuantity=@CollectionQuantity,invoiceNumber=@invoiceNumber,wareRemark=@wareRemark,wareState=@wareState where purchaseID=@purchaseID and internalOrderNumber=@internalOrderNumber
end
--ɾ��
if(@type=3)
begin
delete warehousing where purchaseID=@purchaseID and internalOrderNumber=@internalOrderNumber
end
end
go

--���к�ִ�д洢����
drop procedure pro_execute_serial
go
create procedure pro_execute_serial
@productID nvarchar(30),			--��Ʒ���
@SNCode nvarchar(30),				--S/N��
@sell bit=0,						--�Ƿ��۳�
@entryTime datetime,				--¼��ʱ��
@sellingTime datetime,				--�۳�ʱ��
@serielOperatorID nvarchar(20),		--����Ա���
@type int							--����
as
begin
--����
if(@type=1)
insert into serial values(@productID,@SNCode,@sell,@entryTime,@sellingTime,@serielOperatorID)
--����
if(@type=2)
begin
update serial set sell=@sell,sellingTime=@sellingTime where productID=@productID and SNCode=@SNCode
end
--ɾ��
if(@type=3)
delete serial where productID=@productID and SNCode=@SNCode
end
go

--���ִ�д洢����
drop procedure pro_execute_stock
go
create procedure pro_execute_stock
@inventoryNumber nvarchar(30),	--�����
@productID nvarchar(30),		--��Ʒ���
@productName nvarchar(20),		--��Ʒ����
@model nvarchar(50),			--����ͺ�
@purchasePrice money,			--�ɹ�����
@purchaseincludeTax bit=0,		--�ɹ������Ƿ�˰
@salesPrice money,				--���۵���
@salesincludeTax bit=0,			--���۵����Ƿ�˰
@unit char(2),					--��λ
@inventoryQuantity int,			--�������
@lastWarehousing datetime,		--���һ�����ʱ��
@stockOperatorID nvarchar(20),	--����Ա���
@type int						--����
as
begin
--����
if(@type=1)
begin
insert into stock values(@inventoryNumber,@productID,@productName,@model,@purchasePrice
,@purchaseincludeTax,@salesPrice,@salesincludeTax,@unit,@inventoryQuantity,@lastWarehousing,@stockOperatorID)
end
--����
if(@type=2)
begin
update stock set purchasePrice=@purchasePrice,purchaseincludeTax=@purchaseincludeTax,salesPrice=@salesPrice,salesincludeTax=@salesincludeTax,inventoryQuantity=@inventoryQuantity,lastWarehousing=@lastWarehousing where inventoryNumber=@inventoryNumber
end
--ɾ��
if(@type=3)
begin
delete stock where inventoryNumber=@inventoryNumber
end
end
go

--����ִ�д洢����
drop procedure pro_execute_finance
go
create procedure pro_execute_finance
@financialNumber nvarchar(30)='',		  --������
@internalOrderNumber nvarchar(30)='',	  --�ڲ�������
@paymentDate datetime=null,				  --���񸶿�����
@paymentAmount money=null,				  --������
@paymentRemark nvarchar(100)='',		  --��ע
@financeOperatorID nvarchar(20),	  --����Ա���
@type int							  --����
as
begin
--����
if(@type=1)
begin
insert into finance values(@financialNumber,@internalOrderNumber,@paymentDate,@paymentAmount,@paymentRemark,@financeOperatorID)
end
--����
if(@type=2)
begin
update finance set paymentRemark=@paymentRemark where financialNumber=@financialNumber and internalOrderNumber=@internalOrderNumber
end
--ɾ��
if(@type=3)
begin
delete finance where financialNumber=@financialNumber and internalOrderNumber=@internalOrderNumber
end
end
go

--����ִ�д洢����
drop procedure pro_execute_outgoing
go
create procedure pro_execute_outgoing
@outgoingNumber int=0,						  --������
@officialOrderNumber nvarchar(50),			  --�ͻ������ţ���ʽ�����ţ�
@outgoingcustomerID int,					  --�ͻ����
@outgoingproductID nvarchar(30),			  --��Ʒ���
@outgoingQuantity int,						  --��������
@outgoingDiscount float=1,					  --�ۿ�
@includeTax bit,							  --�Ƿ�˰
@deliveryExpressnumber nvarchar(50),		  --������ݵ���
@deliveryExpressCompany nvarchar(20),		  --������ݹ�˾
@deliveryTime datetime,						  --����ʱ��
@outgoingOperatorID nvarchar(20),			  --����Ա���
@outgoingRemark nvarchar(100),				  --��ע
@outgoingState bit=0,						  --���״̬
@type int									  --����
as
begin
--����
if(@type=1)
begin
insert into outgoing values(@officialOrderNumber,@outgoingcustomerID,@outgoingproductID
,@outgoingQuantity,@outgoingDiscount,@includeTax,@deliveryExpressnumber,@deliveryExpressCompany
,@deliveryTime,@outgoingOperatorID,@outgoingRemark,@outgoingState)
end
--����
if(@type=2)
begin
update outgoing set deliveryExpressnumber=@deliveryExpressnumber,deliveryExpressCompany=@deliveryExpressCompany,deliveryTime=@deliveryTime,outgoingRemark=@outgoingRemark,outgoingState=@outgoingState where outgoingNumber=@outgoingNumber
end
--ɾ��
if(@type=3)
begin
delete outgoing where outgoingNumber=@outgoingNumber
end
end
go

--�û���Ϣִ�д洢����
drop procedure pro_execute_userinfo
go
create procedure pro_execute_userinfo
@loginNumber nvarchar(20),			 --��¼�˺�
@loginPwd nvarchar(max),			 --�û�����
@userName nvarchar(20)='',			 --�û�����
@userRights int=1,					 --�û�Ȩ��
@userStatus bit=1,					 --�û�״̬
@userOperatorID nvarchar(20)='',	 --����Ա���
@type int							 --����
as
begin
--����
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
--����
if(@type=2)
begin
update userinfo set loginPwd=@loginPwd,userStatus=@userStatus where loginNumber=@loginNumber
end
--ɾ��
if(@type=3)
begin
delete userinfo where loginNumber=@loginNumber
exec pro_execute_userprivacy @usernumber,@type=3
end
end
go

--�û���˽ִ�д洢����
drop procedure pro_execute_userprivacy
go
create procedure pro_execute_userprivacy
@userNumber int,						   --�û����
@userName nvarchar(20)='',					   --�û�����
@userNativeplace nvarchar(20)='',		   --����
@userGender bit=0,						   --�Ա�
@userMarriage bit=0,					   --����
@userNation nvarchar(20)='',			   --����
@userBirth datetime=null,				   --��������
@userPolitical nvarchar(20)='',			   --������ò
@userFamilysituation nvarchar(200)='',	   --��ͥ���
@userHomeaddress nvarchar(200)='',		   --��ͥסַ
@userContactinfo nvarchar(50)='',		   --��ϵ��ʽ
@userPhotoURL nvarchar(max)='',			   --����ͷ��URL
@userMonologue nvarchar(max)='',		   --���˶���
@type int								   --����
as
begin
--����
if(@type=1)
begin
insert into userprivacy values(@userNumber,@userName,@userNativeplace,@userGender,@userMarriage
,@userNation,@userBirth,@userPolitical,@userFamilysituation,@userHomeaddress,@userContactinfo
,@userPhotoURL,@userMonologue)
end
--����
if(@type=2)
begin
update userprivacy set userName=@userName,userNativeplace=@userNativeplace,userGender=@userGender
,userMarriage=@userMarriage,userNation=@userNation,userBirth=@userBirth,userPolitical=@userPolitical
,userFamilysituation=@userFamilysituation,userHomeaddress=@userHomeaddress,usercontactinfo=@userContactinfo
,userPhotoURL=@userPhotoURL,userMonologue=@userMonologue where userNumber=@userNumber
end
--ɾ��
if(@type=3)
begin
delete userprivacy where usernumber=@userNumber
end
end
go

--�û�Ȩ��ִ�д洢����
drop procedure pro_execute_rights
go
create procedure pro_execute_rights
@rightsLevel int=0,				 --Ȩ�޵ȼ�
@rightsName nvarchar(20),		 --Ȩ������
@rightsRemark nvarchar(100),	 --Ȩ�ޱ�ע
@type int						 --����
as
begin
--����
if(@type=1)
insert into rights values(@rightsName,@rightsRemark)
--����
if(@type=2)
update rights set rightsName=@rightsName,rightsRemark=@rightsRemark where rightsLevel=@rightsLevel
--ɾ��
if(@type=3)
delete rights where rightsLevel=@rightsLevel
end
go

--�ͻ���Ϣִ�д洢����
drop procedure pro_execute_customerinfo
go
create procedure pro_execute_customerinfo
@customerNumber int,								 --�ͻ����
@customerName nvarchar(20),							 --�ͻ�����
@customerGender bit=0,								 --�ͻ��Ա�
@customerCompany nvarchar(50),						 --��˾����
@customerContactinfo nvarchar(20),					 --��ϵ��ʽ
@customerContactAddress nvarchar(100),				 --��ϵ��ַ
@customerRemark nvarchar(100),						 --��ע
@customerStatus bit=1,								 --�û�״̬
@customerOperatorID nvarchar(20),					 --����Ա���
@type int											 --����
as
begin
--����
if(@type=1)
begin
insert into customerinfo values(@customerName,@customerGender,@customerCompany,@customerContactinfo
,@customerContactAddress,@customerRemark,@customerStatus,@customerOperatorID)
end
--����
if(@type=2)
begin
update customerinfo set @customerName=@customerName,customerGender=@customerGender
,customerCompany=@customerCompany,customerContactinfo=@customerContactinfo,customerContactAddress=@customerContactAddress
,customerRemark=@customerRemark,customerStatus=@customerStatus where customerNumber=@customerNumber
end
--ɾ��
if(@type=3)
delete customerinfo where customerNumber=@customerNumber
end
go

--��Ӧ��ִ�д洢����
drop procedure pro_execute_supplier
go
create procedure pro_execute_supplier
@supplierNumber int=0,				   --��Ӧ�̱��
@supplierName nvarchar(20),			   --��Ӧ������
@supplierInfo nvarchar(100),		   --��Ӧ����Ϣ
@supplierRemark nvarchar(200),		   --��ע
@supplierStatus bit=1,				   --��Ӧ��״̬
@supplierIperatorID nvarchar(20),	   --����Ա���
@type int							   --����
as
begin
--����
if(@type=1)
begin
insert into supplier values(@supplierName,@supplierInfo,@supplierRemark,@supplierStatus,@supplierIperatorID)
end
--����
if(@type=2)
begin
update supplier set supplierName=@supplierName,supplierInfo=@supplierInfo,supplierRemark=@supplierRemark,supplierStatus=@supplierStatus,supplierIperatorID=@supplierIperatorID
where supplierNumber=@supplierNumber
end
--ɾ��
if(@type=3)
delete supplier where supplierNumber=@supplierNumber
end
go

--ά��ִ�д洢����
drop procedure pro_execute_repair
go
create procedure pro_execute_repair
@repairCustomernumber int,						  --�ͻ����
@repairProductID nvarchar(30),					  --��Ʒ���
@repairSNCode nvarchar(30),						  --S/N��
@repairMeg nvarchar(100),						  --ά��ԭ��
@repairName nvarchar(20),						  --ά��������
@repairArrivalTime datetime=null,				  --�ջ�����
@repairExpressNumber nvarchar(50)='',			  --�ջ���ݵ���
@repairExpressCompany nvarchar(20)='',			  --�ջ���ݹ�˾����
@repairContacts nvarchar(30)='',				  --��ϵ������
@repairContactinfo nvarchar(20)='',				  --��ϵ��ʽ
@repairContactAddress nvarchar(100)='',			  --��ϵ��ַ
@repairReturnTime datetime=null,				  --�黹����
@repairReturnExpressNumber nvarchar(50)='',		  --�黹��ݵ���
@repairReturnExpressCompany nvarchar(20)='',	  --�黹��ݹ�˾����
@repairReturnSNCode nvarchar(30)='',			  --��S/N��
@repairOperatorID nvarchar(20),					  --�����˱��
@repairStatus bit=0,							  --���״̬
@type int										  --����
as
begin
--����
if(@type=1)
begin
insert into repair values(@repairCustomernumber,@repairProductID,@repairSNCode
,@repairMeg,@repairName,@repairArrivalTime,@repairExpressNumber,@repairExpressCompany
,@repairContacts,@repairContactinfo,@repairContactAddress,@repairReturnTime,@repairReturnExpressNumber
,@repairReturnExpressCompany,@repairReturnSNCode,@repairOperatorID,@repairStatus)
end
--����
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
--ɾ��
if(@type=3)
begin
delete repair where repairCustomernumber=@repairCustomernumber and repairProductID=@repairProductID
end
end
go

--���ִ�д洢����
drop procedure pro_execute_borrow
go
create procedure pro_execute_borrow
@borrowNumber int,					   --������
@borrowProductID nvarchar(30),		   --��Ʒ���
@borrowSNCode nvarchar(30),			   --S/N��
@borrowQuantity int,				   --����
@borrower nvarchar(20),				   --�����
@borrowOperatorID nvarchar(20),		   --����Ա���
@borrowTime datetime,				   --���ʱ��
@borrowReturnTime datetime=null,	   --�黹ʱ��
@IsReturn bit=0,					   --�Ƿ�黹
@borrowRemark nvarchar(100)='',		   --��ע
@borrowStatus bit=0,				   --���״̬
@type int							   --����
as
begin
--����
if(@type=1)
begin
insert into borrow values(@borrowProductID,@borrowSNCode,@borrowQuantity,@borrower,@borrowOperatorID,@borrowTime,@borrowReturnTime,@IsReturn,@borrowRemark,@borrowStatus)
end
--����
if(@type=2)
begin
update borrow set borrowReturnTime=@borrowReturnTime,IsReturn=@IsReturn,borrowRemark=@borrowRemark,borrowStatus=@borrowStatus 
where borrowNumber=@borrowNumber
end
--ɾ��
if(@type=3)
begin
delete borrow where borrowNumber=@borrowNumber
end
end
go

--�½�ִ�д洢����
drop procedure pro_execute_monthlyknot
go
create procedure pro_execute_monthlyknot
@monthlyKnotNumber int=0,				--�½���
@monthlyKnotProductID nvarchar(30),		--��Ʒ���
@beginmonthNumber int=0,				--�³�����
@monthlyInput int=0,					--�����������
@monthlyOutput int=0,					--���·�������
@endmonthNumber int=0,					--��ĩ����
@thismonth datetime,					--��ǰ����
@type int								--����
as
begin
--����
if(@type=1)
begin
insert into monthlyknot values(@monthlyKnotProductID,@beginmonthNumber,@monthlyInput,@monthlyOutput,@endmonthNumber,@thismonth)
end
--����
if(@type=2)
begin
update monthlyknot set beginmonthNumber=@beginmonthNumber,monthlyInput=@monthlyInput,monthlyOutput=@monthlyOutput,endmonthNumber=@endmonthNumber 
where monthlyKnotNumber=@monthlyKnotNumber
end
--ɾ��
if(@type=3)
begin
delete monthlyknot where monthlyKnotNumber=@monthlyKnotNumber
end
end
go
---------------------------------------------------------------------
--���ڲɹ��������ɹ�������ϸ��ѯ�洢����
drop procedure pro_search_purchaseOrder
go
create procedure pro_search_purchaseOrder
@internalOrderNumber nvarchar(30)='',@officialOrderNumber nvarchar(50)='',@beginTime datetime=null,@endTime datetime=null,@type int
as
begin
--��ѯȫ��
if(@type=1)
select * from purchaseOrder orde left join purchaseGoods good on orde.internalOrderNumber=good.internalOrderNumber
--��ѯĳ��ʱ���
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
--ͨ���ڲ������Ų�ѯ��ϸ����
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
--ͨ����ʽ�����Ų�ѯ��ϸ����
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
--��ѯ��δ��˵Ķ�����ϸ
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
--��ѯ����δ��ɵĶ�����ϸ
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

--���������ϸ��ѯ�洢����
drop procedure pro_search_warehousing
go
create procedure pro_search_warehousing
@purchaseID int=0,@internalOrderNumber nvarchar(30)='',@productID nvarchar(30)='',@type int
as
begin
--��ѯȫ��
if(@type=1)
select * from warehousing
--ͨ���ɹ���Ų�ѯ�����ϸ
if(@type=2)
select * from warehousing where purchaseID=@purchaseID and wareState=0
--ͨ���ڲ������Ų�ѯ�����ϸ
if(@type=3)
select ware.*,goods.productID,goods.purchaseRemark
from warehousing ware
left join purchaseGoods goods on ware.internalOrderNumber=goods.internalOrderNumber
where goods.internalOrderNumber=@internalOrderNumber and wareState=0
end
go

--�������к���ϸ��ѯ�洢����
drop procedure pro_search_serial
go
create procedure pro_search_serial
@serialNumber int=0,@productID nvarchar(30)='',@SNCode nvarchar(30)='',@type int
as
begin
--��ѯȫ��
if(@type=1)
select * from serial
--ͨ�����б�Ų�ѯ��ϸ
else if(@type=2)
select * from serial where serialNumber=@serialNumber
--ͨ����Ʒ��Ų�ѯ��ϸ
else if(@type=3)
select * from serial where productID=@productID and sell=0
--�Ƿ���ڴ�SN����
else if(@type=4)
select * from serial where productID=@productID and SNCode=@SNCode
end
go

--���ڿ����ϸ��ѯ�洢����
drop procedure pro_search_stock
go
create procedure pro_search_stock
@inventoryNumber nvarchar(30)='',@productID nvarchar(30)='',@productName nvarchar(20)='',@model nvarchar(50)='',@type int
as
begin
--��ѯȫ��
if(@type=1)
select * from stock
--ͨ������Ų�ѯ
else if(@type=2)
select * from stock where inventoryNumber=@inventoryNumber
--ͨ����Ʒ��Ų�ѯ
else if(@type=3)
select * from stock where productID=@productID
--ͨ����Ʒ���ƺ͹���ͺŲ�ѯ
else if(@type=4)
select * from stock where productName=@productName and model=@model
else if(@type=5)
select productID,productName,model from stock
end
go

--���ڲ�����ϸ��ѯ�洢����
drop procedure pro_search_finance
go
create procedure pro_search_finance
@internalOrderNumber nvarchar(20)='',@type int
as
begin
--��ѯȫ��
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
--��ѯ�����ܽ���ϸ
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

--���ڳ�����ϸ��ѯ�洢����
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
--�����û���Ϣ��ϸ��ѯ�洢����
drop procedure pro_search_userinfo
go
create procedure pro_search_userinfo
@userNumber int=0,@loginNumber nvarchar(20)='',@loginPwd nvarchar(max)='',@type int
as
begin
--��ѯȫ��
if(@type=1)
select uinfo.userNumber,loginNumber,userRights,userOperatorID,userStatus,privacy.userName,rights.rightsName 
from userinfo uinfo
left join userprivacy privacy on uinfo.userNumber=privacy.userNumber
left join rights rights on rights.rightsLevel=uinfo.userRights
--��ѯ�Ƿ����
else if(@type=2)
select loginNumber,userRights,privacy.userName from userinfo uinfo
left join userprivacy privacy on uinfo.userNumber=privacy.userNumber 
where loginNumber=@loginNumber and loginpwd=@loginPwd and userStatus=1
end
go

--���ڿͻ���Ϣ��ϸ��ѯ�洢����
drop procedure pro_search_customerinfo
go
create procedure pro_search_customerinfo
@customerNumber int=0,@type int
as
begin
--��ѯȫ��
if(@type=1)
select * from customerinfo where customerStatus=1
--��ѯָ���ͻ���ϸ
if(@type=2)
select * from customerinfo where customerNumber=@customerNumber and customerStatus=1
end
go

--���ڹ�Ӧ����ϸ��ѯ�洢����
drop procedure pro_search_supplier
go
create procedure pro_search_supplier
@supplierNumber int='',@type int
as
begin
--��ѯȫ��
if(@type=1)
select * from supplier where supplierStatus=1
end
go
--����ά����ϸ��ѯ�洢����
drop procedure pro_search_repair
go
create procedure pro_search_repair
@repairCustomernumber int=0,@repairProductID nvarchar(30)='',@repairSNCode nvarchar(30)='',@type int
as
begin
--��ѯȫ��
if(@type=1)
select repa.*,stoc.productName,stoc.model,customer.customerName from repair repa 
left join stock stoc on repa.repairProductID=stoc.productID
left join customerinfo customer on customer.customerNumber=repa.repairCustomernumber
where repa.repairStatus=0
--��ѯָ���ͻ���Ʒ��ϸ
else if(@type=2)
select repa.*,stoc.productName,stoc.model,customer.customerName from repair repa 
left join stock stoc on repa.repairProductID=stoc.productID
left join customerinfo customer on customer.customerNumber=repa.repairCustomernumber
where repa.repairCustomernumber=@repairCustomernumber and repa.repairProductID=@repairProductID 
and repa.repairSNCode=@repairSNCode and repa.repairStatus=0
end
go
--���ڽ����ϸ��ѯ�洢����

--�����½���ϸ��ѯ�洢����
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
--��ѯδ��˵���ϸ��������
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
--�����ܽ������
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

----------------------------------������-----------------------------------
--��ⴥ���½�����
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
--���ⴥ���½�����
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
--�����Ӵ����½�����
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

--��ⴥ�����Ŀ��
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
--���ⴥ�����Ŀ��
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

--��ɾ���û���Ϣʱͬ��ɾ���û���˽
create trigger trig_userinfo_userprivacy
on userinfo
for delete
as
declare @usernumber int
set @usernumber=(select userNumber from deleted)
delete userprivacy where userNumber=@usernumber
go