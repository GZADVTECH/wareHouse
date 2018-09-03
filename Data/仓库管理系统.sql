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
	supplier nvarchar(50),--��Ӧ������
	supplierID nvarchar(50),--��Ӧ�̶�����
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
	amount int,--����
	unitPrice money,--�ɹ�����
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
	paySum money--������
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
	arrivalDate datetime,--�ջ�����
	trackingID nvarchar(50),--��ݵ���
	trackingName nvarchar(50),--��ݹ�˾����
	contactsID nvarchar(20),--��ϵ�˱��
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

