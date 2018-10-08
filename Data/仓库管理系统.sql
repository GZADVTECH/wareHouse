use master
go

create database DB_wareHouse
go

use DB_wareHouse
go

--�ɹ�������
create table procurement
(
	autoID int identity(1,1),--�Զ����
	pID nvarchar(20) primary key,--�ڲ������ţ�AVG��
	contractOrder nvarchar(50),--��ʽ������
	userID nvarchar(20),--�ɹ�Ա�˺�
	clientID int,--�ͻ����
	buyDate datetime,--��������
	arrivalDate datetime,--Ԥ�Ƶ���ʱ��
	[check] bit,--�������ǩ��
)
go

--�ɹ������
create table procurement_cargo
(
	autoID int identity(1,1),--�Զ����
	pID nvarchar(20),--�ڲ�������
	productID nvarchar(50),--��Ʒ���
	isParts bit,--�Ƿ������ײ�Ʒ
	supplierID int,--��Ӧ�̱��
	amount int,--����
	isTax bit,--�ɹ������Ƿ�˰
	unitPrice money,--�ɹ�����
	sellisTax bit,--���۵����Ƿ�˰
	sellPrice money,--���۵���
	discount float,--�ۿ�
	totalPrices money,--�ɹ��ܽ��
	isInvoice bit,--�Ƿ��з�Ʊ
)
go

--����
create table storage_cargo
(
	autoID int,--�����
	pID nvarchar(20),--�ڲ�������
	trackingID nvarchar(50),--��ݵ���
	trackingName nvarchar(50),--��ݹ�˾����
	location nvarchar(20),--��λ
	supplierOrderID nvarchar(50),--��Ӧ�̶�����
	deliveryDate datetime,--�ջ�����
	productID nvarchar(50),--��Ʒ����
	actualAmount int,--ʵ������
	consigneeID nvarchar(20),--�ջ����˺�
	invoiceID nvarchar(50),--��Ʊ����
	checkTaker nvarchar(20),--�շ�Ʊ��
	remark nvarchar(max),--��ע
)
go

--���кű�
create table SNIDTable
(
	pID nvarchar(20),--�ڲ�������
	productID nvarchar(50),--��Ʒ���
	SNID nvarchar(50),--S/N��
	isSell bit default(0),--�Ƿ��۳�
)
go

--�û���Ϣ��
create table user_Message
(
	autoID int identity(1,1),--�Զ����
	userID nvarchar(20) primary key,--�û��˺�
	userName nvarchar(20),--�û�����
	userPwd nvarchar(max),--�û�����
	userLimit int--�û�Ȩ��
)
go

--�û�Ȩ�ޱ�
create table user_Limit
(
	autoID int identity(1,1) primary key,--�Զ����
	limitName nvarchar(30)--Ȩ������
)
go

--�����
create table financeTable
(
	pID nvarchar(20),--�ڲ�������
	financeID int,--������
	payDate datetime,--���񸶿�����
	paySum money,--������
	remark nvarchar(max),--��ע
)
go

--�����
create table delivery_cargo
(
	autoID int identity(1,1),--�Զ����
	cOrderID nvarchar(50),--�ͻ�������
	cID nvarchar(20),--�ͻ����
	productID nvarchar(50),--��Ʒ���
	[count] int,--����
	sellingPrice money,--���۵���
	discount float,--�ۿ�
	deliveryIsTax bit,--�Ƿ�˰
	discountPrice money,--�ۺ��
	sellingPrices money,--�ܽ��
	trackingID nvarchar(50),--��ݵ���
	trackingName nvarchar(50),--��ݹ�˾����
	arrivalDate datetime,--����ʱ��
	consignerID nvarchar(20),--�����˱��
	Remark nvarchar(max),--��ע
)
go
--����
create table inventory_Table
(
	autoID int identity(1,1),--�Զ����
	productID nvarchar(50) primary key,--��Ʒ���
	productName nvarchar(50),--��Ʒ����
	PNID nvarchar(50),--���
	unitPrice money,--�ɹ�����
	sellPrice money,--���۵���
	unit char(2),--��λ
	quantity int,--�������
)
go

--ά�ޱ�
create table maintenanceTable
(
	cID int,--�ͻ����
	productID nvarchar(50),--��Ʒ���
	SNID nvarchar(50),--SNID
	maintenanceMsg nvarchar(max),--ά��ԭ��
	maintenanceName nvarchar(50),--ά��������
	arrivalDate datetime,--�ջ�����
	trackingID nvarchar(50),--��ݵ���
	trackingName nvarchar(50),--��ݹ�˾����
	contactsID nvarchar(20),--��ϵ�˱��
	returnproductID nvarchar(50),--�黹��Ʒ���
	returnDate datetime,--�黹����
	returntrackingID nvarchar(50),--�黹��ݵ���
	returntrackingName nvarchar(50),--�黹��ݹ�˾����
)
go

--�ͻ���Ϣ��
create table ClientTable
(
	autoID int identity(1,1) primary key,--�Զ����
	cName nvarchar(20),--�ͻ�����
	cway nvarchar(20),--��ϵ��ʽ
	cAddress nvarchar(max),--��ϵ��ַ
)
go

--�����
create table loanTable
(
	autoID int identity(1,1),--�Զ����
	productID nvarchar(50),--��Ʒ���
	[count] int,--����
	salePrice money,--���ۼ۸�
	lenders nvarchar(20),--�����
	approverID  nvarchar(20),--������
	borrowDate datetime,--���ʱ��
	returnDate datetime,--�黹ʱ��
	isReturn bit,--�Ƿ�黹
	remark nvarchar(max),--��ע
)
go

--��Ӧ�̱�
create table supplierTable
(
	autoID int identity(1,1),--�Զ����
	supperName nvarchar(50),--��Ӧ������
	supperMsg nvarchar(max),--��Ӧ����Ϣ
	remark nvarchar(max),--��ע
)
go
create table monthly
(
	autoID int identity(1,1),--�Զ����
	storageDate datetime,--�������
	materielID nvarchar(50),--���ϱ���

)
------------------------------�洢����----------------------------------------
--��֤�˺������Ƿ����,������ڣ����ر�ţ�������Ȩ�޵���Ϣ
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

--��ѯ����޸Ŀͻ���Ϣ
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

--��Ӧ���ۺϲ���
create proc pro_supplier
@name nvarchar(50),@msg nvarchar(max)='',@remark nvarchar(max)='',@typeid int
as
begin
--��ѯ����
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
--��������
else if(@typeid=1)
begin
insert into supplierTable values(@name,@msg,@remark)
end
--����
else if(@typeid=2)
begin
update supplierTable set supperName=@name,supperMsg=@msg,remark=@remark where autoID=(select autoID from supplierTable where supperName=@name)
end
--ɾ��
else if(@typeid=3)
begin
delete supplierTable where autoID=(select autoID from supplierTable where supperName=@name)
end
end
go

--�ɹ������ۺϲ���
create procedure pro_procurement
@pid nvarchar(20),@orderID nvarchar(50),@userid nvarchar(20),@buydate datetime,@arrivaldate datetime,@check bit=0,@cid int,@typeid int
as
begin
--��ѯ
if(@typeid=0)
begin
select * from procurement pro left join procurement_cargo procargo on pro.pID=procargo.pID or contractOrder=@orderID
end
--����
else if(@typeid=1)
begin
insert into procurement values(@pid,@orderID,@userid,@cid,@buydate,@arrivaldate,@check)
end
--����
else if(@typeid=2)
update procurement set contractOrder=@orderID,buyDate=@buydate,arrivalDate=@arrivaldate,[check]=@check where pID=@pid
--ɾ��
else if(@typeid=3)
delete procurement where pID=@pid
end
go

--�ɹ���Ʒ�ۺϲ���
create proc pro_procargo
@pid nvarchar(20)='',@productID nvarchar(50)='',@isparts bit,@supplierid int=0,@amount int=0,@istax bit,@unitprice money='',@sellistax bit,@sellprice money
,@discount float=0,@isInvoice bit,@typeid int
as
begin
--��ѯ
if(@typeid=0)
select * from procurement_cargo
else if(@typeid=1)
select * from procurement_cargo where pID=@pid
else if(@typeid=2)
select * from procurement_cargo where productID=@productID
--����
else if(@typeid=3)
insert into procurement_cargo values(@pid,@productID,@isparts,@supplierid,@amount,@istax,@unitprice,@sellistax,@sellprice,@discount,@amount*@unitprice*@discount,@isInvoice)
--����
else if(@typeid=4)
update procurement_cargo set isParts=@isparts,supplierID=@supplierid,amount=@amount,isTax=@istax,discount=@discount,sellisTax=@sellistax,sellPrice=@sellprice,totalPrices=@amount*@unitprice*@discount,isInvoice=@isInvoice where pid=@pid and productID=@productID
--ɾ��
else if(@typeid=5)
delete procurement_cargo where pid=@pid and productID=@productID
end
go

--�����ۺϲ���
create proc pro_inventory
@pid nvarchar(50)='',@productname nvarchar(50)='',@pnid nvarchar(50)='',@unitprice money='',@sellprice money='',@unit char(2)='',@quantity int='',@typeid int
as
begin 
--��ѯ
if(@typeid=0)
begin
if(@productname<>'')
select distinct * from inventory_Table where productName=@productname
else if(@pid<>'')
select * from inventory_Table where productID=@pid
else
select distinct * from inventory_Table
end
--����
else if(@typeid=1)
begin
insert into inventory_Table values(@pid,@productname,@pnid,@unitprice,@sellprice,@unit,@quantity)
end
--����
else if(@typeid=2)
update inventory_Table set productName=@productname,PNID=@pnid,unitPrice=@unitprice,sellPrice=@sellprice,unit=@unit,quantity=@quantity where productID=@pid
--ɾ��
else if(@typeid=3)
delete inventory_Table where productID=@pid
--��ѯ��Ʒ����
else if(@typeid=4)
select Max(productName) as productName from inventory_Table group by productName
--ͨ����Ʒ���Ƽ�����ѯ��Ʒ
else if(@typeid=5)
select * from inventory_Table where productName=@productname and PNID=@pnid
end
go

--ͨ����Ų�ѯ������ϸ��Ϣ
alter proc pro_proc_inven
@pid nvarchar(20)
as
begin
select pro.[check],pro.pID,pro.contractOrder,userm.userName,client.cName,pro.buyDate,pro.arrivalDate,inven.productID,supp.autoID,inven.productName,inven.PNID,cargo.autoID as cargoautoID,cargo.amount,supp.supperName,cargo.discount,cargo.unitPrice,cargo.isTax,cargo.sellisTax,cargo.sellPrice,cargo.isParts,cargo.isInvoice
from procurement pro
 left join procurement_cargo cargo on cargo.pID=pro.pID
 left join inventory_Table inven on cargo.productID=inven.productID 
 left join user_Message userm on pro.userID=userm.userID 
 left join ClientTable client on pro.clientID=client.autoID 
 left join supplierTable supp on cargo.supplierID=supp.autoID 
 where pro.pID=@pid
end
go

--����ۺϲ���
create proc pro_cargo
@storageid int='',@pid nvarchar(20),@tid nvarchar(50)='',@tname nvarchar(50)='',@location nvarchar(20)='',@soid nvarchar(50)='',@deliverydate datetime='',@productid nvarchar(50)=''
,@actualamount int=0,@consigneeid nvarchar(50)='',@invoiceid nvarchar(50)='',@checktaker nvarchar(20)='',@remark nvarchar(max)='',@typeid int
as
begin
--��ѯ
if(@typeid=0)
begin
select * from storage_cargo where autoID=@storageid or pid=@pid
end
--����
else if(@typeid=1)
begin
insert into storage_cargo values(@storageid,@pid,@tid,@tname,@location,@soid,@deliverydate,@productid,@actualamount,@consigneeid,@invoiceid,@checktaker,@remark)
end
--����
else if(@typeid=2)
begin
update storage_cargo set trackingID=@tid,trackingName=@tname,location=@location,supplierOrderID=@soid,deliveryDate=@deliverydate,productID=productID,actualAmount=@actualamount
,consigneeID=@consigneeid,invoiceID=@invoiceid,checkTaker=@checktaker,remark=@remark where pID=@pid and autoID=@storageid
end
else if(@typeid=3)
begin
delete storage_cargo where pid=@pid or autoID=@storageid
end
end
go

--�û���Ϣ�ۺϲ���
create proc pro_user
@userid nvarchar(20)='',@username nvarchar(20)='',@userpwd nvarchar(max)='',@userlimit int='',@typeid int
as
begin
--��ѯ
if(@typeid=0)
begin
--���idΪ�գ���ѯȫ����Ϣ����Ϊ�ղ�ѯָ��id����Ϣ
if(@userid='')
begin
select * from user_Message
end
else
begin
select * from user_Message where userID=@userid
end
end
--����
else if(@typeid=1)
begin
insert into user_Message values(@userid,@username,@userpwd,@userlimit)
end
--����
else if(@typeid=2)
begin
update user_Message set @username=@username,@userpwd=@userpwd,userLimit=@userlimit where userID=@userid
end
--ɾ��
else if(@typeid=3)
begin
delete user_Message where userID=@userid
end
end
go

--SN���ۺϲ���
alter proc pro_snid
@pid nvarchar(20),@productid nvarchar(50),@snid nvarchar(50)='',@issell bit=0,@typeid int
as
begin
--��ѯ
if(@typeid=0)
begin
select snid.*,inven.productName,inven.PNID from SNIDTable snid left join inventory_Table inven on snid.productID=inven.productID where pid=@pid and snid.productID=@productid and isSell=@issell
end
--����
else if(@typeid=1)
begin
insert into SNIDTable values(@pid,@productid,@snid,@issell)
end
--����
else if(@typeid=2)
begin
update SNIDTable set SNID=@snid,isSell=@issell where pid=@pid and productID=@productid and SNID=@snid
end
--ɾ��
else if(@typeid=3)
begin
delete SNIDTable where pid=@pid and productID=@productid and SNID=@snid
end
end
go

--���񱨱��ѯ
alter proc pro_finace
@pid nvarchar(20)=''
as
begin
if(@pid<>'')
begin
select  pro.pID,pro.buyDate,sup.supperName,cargo.totalPrices,cargo.isTax,pro.arrivalDate,pro.[check]
,inven.productName,cargo.unitPrice,cargo.amount,client.cName,storage.deliveryDate,storage.actualAmount
,storage.invoiceID,delivery.cOrderID,delivery.sellingPrices,delivery.deliveryIsTax,finance.remark,finance.payDate,finance.paySum,cargo.autoID
from procurement pro
left join procurement_cargo cargo on pro.pID=cargo.pID
left join inventory_Table inven on inven.productID=cargo.productID
left join storage_cargo storage on storage.autoID=cargo.autoID
left join supplierTable sup on sup.autoID=cargo.supplierID
left join ClientTable client on client.autoID=pro.clientID
left join financeTable finance on finance.financeID=cargo.autoID
left join delivery_cargo delivery on delivery.cOrderID=pro.contractOrder
where pro.pID=@pid
end
else
begin
select  pro.pID,pro.buyDate,sup.supperName,cargo.totalPrices,cargo.isTax,pro.arrivalDate,pro.[check]
,inven.productName,cargo.unitPrice,cargo.amount,client.cName,storage.deliveryDate,storage.actualAmount
,storage.invoiceID,delivery.cOrderID,delivery.sellingPrices,delivery.deliveryIsTax,finance.remark,finance.payDate,finance.paySum,cargo.autoID
from procurement pro
left join procurement_cargo cargo on pro.pID=cargo.pID
left join inventory_Table inven on inven.productID=cargo.productID
left join storage_cargo storage on storage.autoID=cargo.autoID
left join supplierTable sup on sup.autoID=cargo.supplierID
left join ClientTable client on client.autoID=pro.clientID
left join financeTable finance on finance.financeID=cargo.autoID
left join delivery_cargo delivery on delivery.cOrderID=pro.contractOrder
end
end
go

--������ۺϲ���
create proc pro_finance
@pid nvarchar(20),@financeID int,@payDate datetime='',@paySum money='',@remark nvarchar(max)='',@typeid int
as
begin
--��ѯ
if(@typeid=0)
begin
if(@pid<>'')
begin
select * from financeTable where pID=@pid and financeID=@financeID
end
else
begin
select * from financeTable
end
end
--����
else if(@typeid=1)
begin
insert into financeTable values(@pid,@financeID,@payDate,@paySum,@remark)
end
--����
else if(@typeid=2)
begin
update financeTable set payDate=@payDate,paySum=@paySum,remark=@remark where pID=@pid and financeID=@financeID
end
--ɾ��
else if(@typeid=3)
begin
delete financeTable where pID=@pid and financeID=@financeID
end
end
go

--ͨ����ͬ�����Ų�ѯ��ϸ��Ϣ
create proc pro_contractOrder
@contractorder nvarchar(50)
as
begin
select pro.contractOrder,pro.clientID,client.cName,cargo.productID,inven.productName,inven.PNID,cargo.amount,cargo.unitPrice,cargo.isTax,cargo.sellPrice,cargo.sellisTax,delivery.discount
from procurement pro
left join ClientTable client on client.autoID=pro.clientID
left join procurement_cargo cargo on cargo.pID=pro.pID
left join inventory_Table inven on inven.productID=cargo.productID
left join delivery_cargo delivery on delivery.cOrderID=pro.contractOrder
where pro.contractOrder=@contractorder
end
go

--������ۺϲ���
create proc pro_delivery
@orderid nvarchar(20)='',@cid nvarchar(20)='',@productid nvarchar(50)='',@count int=0,@sellingPrice money='',@discount float='',@deliveryistax bit='',@discountprice money=''
,@sellingprices money='',@trackingid nvarchar(50)='',@trackingname nvarchar(50)='',@arrivaldate datetime='',@consignerid nvarchar(20)='',@remark nvarchar(max)='',@typeid int
as
begin
--��ѯ
if(@typeid=0)
begin
if(@orderid<>'')
select * from delivery_cargo
else
select * from delivery_cargo where cOrderID=@orderid
end
--����
else if(@typeid=1)
begin
insert into delivery_cargo values(@orderid,@cid,@productid,@count,@sellingPrice,@discount,@deliveryistax,@discountprice,@sellingprices,@trackingid,@trackingname,@arrivaldate,@consignerid,@remark)
end
--����
else if(@typeid=2)
begin
update delivery_cargo set [count]=@count,discount=@discount,discountPrice=@sellingPrice*@discount,sellingPrices=@sellingPrice*@count*@discount,trackingID=@trackingid
,trackingName=@trackingname,arrivalDate=@arrivaldate,Remark=@remark where cOrderID=@orderid and productID=@productid
end
--ɾ��
else if(@typeid=3)
begin
delete delivery_cargo where cOrderID=@orderid and productID=@productid
end
end
go

--ά�ޱ��ۺϲ���
alter proc pro_maintenance
@cid int='',@proid nvarchar(50)='',@snid nvarchar(50)='',@mainmsg nvarchar(max)='',@mainname nvarchar(50)='',@arrivaldate datetime='',@trackingid nvarchar(50)='',@trackingname nvarchar(50)=''
,@contid nvarchar(20)='',@returnproid nvarchar(50)='',@returndate datetime='',@returntrackid nvarchar(50)='',@returntrackname nvarchar(50)='',@typeid int,@RETURN_VALUE int=0 output
as
begin
--��ѯ
if(@typeid=0)
begin
if(@cid='' and @proid='' and @snid='')
select main.*,inven.productName,inven.PNID,client.cName from maintenanceTable main
left join inventory_Table inven on inven.productID=main.productID
left join ClientTable client on client.autoID=main.cID
else
select main.*,inven.productName,inven.PNID,client.cName from maintenanceTable main
left join inventory_Table inven on inven.productID=main.productID
left join ClientTable client on client.autoID=main.cID
where cID=@cid and main.productID=@proid and SNID=@snid
end
--����
if(@typeid=1)
begin
insert into maintenanceTable values(@cid,@proid,@snid,@mainmsg,@mainname,@arrivaldate,@trackingid,@trackingname,@contid,@returnproid,@returndate,@returntrackid,@returntrackname)
set @RETURN_VALUE=@@ROWCOUNT
return @RETURN_VALUE
end
--����
if(@typeid=2)
begin
update maintenanceTable set maintenanceMsg=@mainmsg,@mainname=@mainname,arrivalDate=@arrivaldate,trackingID=@trackingid,trackingName=@trackingname,contactsID=@contid
,returnproductID=@returnproid,returnDate=@returndate,returntrackingID=@returntrackid,returntrackingName=@returntrackname where cID=@cid and productID=@proid and SNID=@snid
set @RETURN_VALUE=@@ROWCOUNT
return @RETURN_VALUE
end
--ɾ��
if(@typeid=3)
begin
delete maintenanceTable where cID=@cid and productID=@proid and SNID=@snid
set @RETURN_VALUE=@@ROWCOUNT
return @RETURN_VALUE
end
end
go
--δ�����ϸ
alter proc pro_cargo_pro
as
begin
select pro.*,cargo.*,inven.productName,inven.PNID,client.cName,userm.userName 
from procurement pro
left join procurement_cargo cargo on cargo.pID=pro.pID
left join inventory_Table inven on inven.productID=cargo.productID
left join ClientTable client on client.autoID=pro.clientID
left join user_Message userm on userm.userID=pro.userID
where pro.[check]=0
end
go
-----------------------------��������-----------------------------------------
--�����û�Ȩ�ޱ���Ϣ
insert into user_Limit values('��������Ա'),('�ɹ�����Ա'),('�������Ա'),('�ֿ����Ա'),('��������Ա')
go
select * from user_Limit
go

--���볬������Ա��������
insert into user_Message values('admin','��������Ա','88888888',1)
go
select * from user_Message
go
--�ɹ�������������
select pro.pID,client.cName,inv.productName,inv.PNID,inv.unit,cargo.amount,inv.unitPrice,pro.buyDate,pro.arrivalDate,cargo.isTax,cargo.isParts from procurement pro 
left join procurement_cargo cargo on pro.pID=cargo.pID 
left join inventory_Table inv on cargo.productID=inv.productID 
left join ClientTable client on pro.clientID=client.autoID
--�ջ�֪ͨ����������
select usemes.userName,pro.pID,supp.supperName,pro.arrivalDate,inven.productName,inven.PNID,cargo.amount,cargo.isInvoice from procurement pro 
left join procurement_cargo cargo on pro.pID=cargo.pID
left join inventory_Table inven on cargo.productID=inven.productID
left join supplierTable supp on cargo.supplierID=supp.autoID
left join user_Message usemes on usemes.userID=pro.userID
--���񱨱�����
 select  pro.pID,pro.buyDate,pro.contractOrder,cargo.totalPrices,cargo.isTax,pro.arrivalDate,pro.[check]
,inven.productName,cargo.unitPrice,cargo.amount,client.cName,storage.deliveryDate,storage.actualAmount
,storage.invoiceID,cargo.sellPrice,cargo.sellisTax,finance.remark,finance.payDate,finance.paySum,cargo.autoID
from procurement pro
left join procurement_cargo cargo on pro.pID=cargo.pID
left join inventory_Table inven on inven.productID=cargo.productID
left join storage_cargo storage on storage.autoID=cargo.autoID
left join supplierTable sup on sup.autoID=cargo.supplierID
left join ClientTable client on client.autoID=pro.clientID
left join financeTable finance on finance.financeID=cargo.autoID

---------------------------�������������---------------------------------
insert into procurement values('AVG1809061334','admin','2018/9/6','2018/9/6',0,1)
insert into inventory_Table values('00001','��ӡ��','SN154',1200,2300,'̨',3),('00002','��ӡ��','SL1130',1000,2100,'̨',1),('00003','��ӡͷ','1255',12000,20000,'̨',0),('00004','ɫ��','110mm',120,200,'��',10)
insert into procurement_cargo values('AVG1809061334','00001','1',2,1300,0,2600)
insert into procurement_cargo values('AVG1809061334','00002','1',1,1300,0,2600)

select * from inventory_Table

select * from inventory_Table where productID='ATY59764'

select pro.pID,client.cName,inv.productName,inv.PNID,inv.unit,cargo.amount,inv.unitPrice,pro.arrivalDate from procurement pro left join procurement_cargo cargo on pro.pID=cargo.pID left join inventory_Table inv on cargo.productID=inv.productID left join ClientTable client on pro.clientID=client.autoID

select pro.*,inv.*,cargo.*,client.* from procurement pro left join procurement_cargo cargo on pro.pID=cargo.pID left join inventory_Table inv on cargo.productID=inv.productID left join ClientTable client on pro.clientID=client.autoID
 
select * from procurement_cargo
select * from procurement
select * from inventory_Table
select * from SNIDTable
select * from storage_cargo

select i.* from 
(select  pro.buyDate,sup.supperName,cargo.unitPrice,cargo.isTax,pro.arrivalDate,pro.[check],inven.productName
,inven.PNID,inven.unitPrice as a ,cargo.amount,client.cName,storage.deliveryDate,storage.actualAmount
from procurement pro
left join procurement_cargo cargo on pro.pID=cargo.pID
left join inventory_Table inven on inven.productID=cargo.productID
left join (select distinct pID,trackingID,deliveryDate,actualAmount,autoID from storage_cargo) storage on storage.autoID=cargo.autoID
left join supplierTable sup on sup.autoID=cargo.supplierID
left join ClientTable client on client.autoID=pro.clientID) as i



select * from procurement_cargo
select * from storage_cargo
select * from procurement_cargo cargo
left join storage_cargo sto on sto.pID=cargo.pID 


select i.*,stor.trackingID from (select  pro.pID,pro.buyDate,sup.supperName,cargo.unitPrice,cargo.isTax,pro.arrivalDate,pro.[check],inven.productName
,inven.PNID,inven.unitPrice as a ,cargo.amount,client.cName
from procurement pro
left join procurement_cargo cargo on pro.pID=cargo.pID
left join inventory_Table inven on inven.productID=cargo.productID
left join supplierTable sup on sup.autoID=cargo.supplierID
left join ClientTable client on client.autoID=pro.clientID) as i,storage_cargo stor where i.pID=stor.pID

select pro.*,cargo.* from (select * from procurement) as pro,(select * from storage_cargo) as cargo,(select  pro.pID,pro.buyDate,sup.supperName,cargo.unitPrice,cargo.isTax,pro.arrivalDate,pro.[check],inven.productName
,inven.PNID,inven.unitPrice as a ,cargo.amount,client.cName
from procurement pro
left join procurement_cargo cargo on pro.pID=cargo.pID
left join inventory_Table inven on inven.productID=cargo.productID
left join supplierTable sup on sup.autoID=cargo.supplierID
left join ClientTable client on client.autoID=pro.clientID)as i
go

select * from procurement pro 
left join storage_cargo storage on pro.pID=storage.pID
left join ClientTable client on client.autoID=pro.clientID
select * from procurement_cargo cargo
 left join inventory_Table inven on inven.productID=cargo.productID
 left join supplierTable sup on sup.autoID=cargo.supplierID
