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
	userID nvarchar(20),--�ɹ�Ա�˺�
	buyDate datetime,--�ɹ�����
	arrivalDate datetime,--Ԥ�Ƶ���ʱ��
	[check] bit,--�������ǩ��
	isInvoice bit,--�Ƿ��з�Ʊ
)
go

--�ɹ������
create table procurement_cargo
(
	autoID int identity(1,1),--�Զ����
	pID nvarchar(20),--�ڲ�������
	productID nvarchar(50),--��Ʒ���
	supplierID int,--��Ӧ�̱��
	amount int,--����
	unitPrice money,--�ɹ�����
	discount float,--�ۿ�
	totalPrices money,--�ɹ��ܽ��
)
go

--����
create table storage_cargo
(
	autoID int identity(1,1),--�Զ����
	pID nvarchar(20),--�ڲ�������
	trackingID nvarchar(50),--��ݵ���
	trackingName nvarchar(50),--��ݹ�˾����
	location nvarchar(20),--��λ
	supplierOrderID nvarchar(50),--��Ӧ�̶�����
	deliveryDate datetime,--�ջ�����
	actualAmount int,--ʵ������
	consigneeID nvarchar(20),--�ջ����˺�
	invoiceID nvarchar(50),--��Ʊ����
	check_taker nvarchar(20),--�շ�Ʊ��
	remark nvarchar(max),--��ע
)
go

--���кű�
create table SNIDTable
(
	pID nvarchar(20),--�ڲ�������
	PNID nvarchar(50),--���
	SNID nvarchar(50) unique--S/N��
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
	payDate datetime,--���񸶿�����
	paySum money,--������
	remark nvarchar(max),--��ע
)
go

--�����
create table delivery_cargo
(
	autoID int identity(1,1),--�Զ����
	cOrderID nvarchar(20),--�ͻ�������
	cID nvarchar(20),--�ͻ����
	productID nvarchar(50),--��Ʒ���
	[count] int,--����
	discount float,--�ۿ�
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
	unitPrice money,--����
	quantity int,--�������
)
go

--ά�ޱ�
create table maintenanceTable
(
	cID int identity(1,1),--�ͻ����
	productID nvarchar(50),--��Ʒ���
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