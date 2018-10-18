use master 
go

drop database DB_XC
go
create database DB_XC
go

use DB_XC
go

--�ɹ�������
drop table purchaseOrder
go
create table purchaseOrder
(
	internalOrderNumber nvarchar(30),--�ڲ�������
	officialOrderNumber nvarchar(50),--��ʽ������
	operatorID nvarchar(20),		 --����Ա���
	customerID int,					 --�ͻ����
	arrivalTime datetime,			 --Ԥ�Ƶ���ʱ��
	creationTime datetime,			 --����ʱ��
	auditStatus bit,				 --�������״̬
	completeState bit,				 --�������״̬
)
go

--�ɹ������
drop table purchaseGoods
go
create table purchaseGoods
(
	purchaseID int identity(1,1),		  --�ɹ����
	internalOrderNumber nvarchar(30),	  --�ڲ�����
	productID nvarchar(30),				  --��Ʒ���
	supportingProducts bit,				  --�Ƿ������ײ�Ʒ
	supplierNumber int,					  --��Ӧ�̱��
	purchaseQuantity int,				  --�ɹ�����
	invoice bit,						  --�Ƿ��з�Ʊ
	purchaseRemark nvarchar(100),		  --��ע
)
go

--����
drop table warehousing
go
create table warehousing
(
	purchaseID int,							   --�ɹ����
	internalOrderNumber nvarchar(30),		   --�ڲ�������
	receiptExpressNumber nvarchar(50),		   --�ջ���ݵ���
	receiptExpressCompany nvarchar(20),		   --�ջ���ݹ�˾
	productionPosition nvarchar(20),		   --��λ
	supplierRelevantNumber nvarchar(50),	   --��Ӧ����ر��
	storageDate datetime,					   --�������
	CollectionQuantity int,					   --ʵ������
	wareOperatorID nvarchar(20),			   --����Ա���
	invoiceNumber nvarchar(50),				   --��Ʊ����
	wareRemark nvarchar(100),				   --��ע
	wareState bit,							   --���״̬
)
go

--���кű�
drop table serial
go
create table serial
(
	serialNumber int identity(1,1),		--���б��
	productID nvarchar(30),				--��Ʒ���
	SNCode nvarchar(30),				--S/N��
	sell bit,							--�Ƿ��۳�
	entryTime datetime,					--¼��ʱ��
	sellingTime datetime,				--�۳�ʱ��
	serielOperatorID nvarchar(20),		--����Ա���
)
go

--����
drop table stock
go
create table stock
(
	inventoryNumber nvarchar(30),	--�����
	productID nvarchar(30),			--��Ʒ���
	productName nvarchar(20),		--��Ʒ����
	model nvarchar(50),				--����ͺ�
	purchasePrice money,			--�ɹ�����
	purchaseincludeTax bit,			--�ɹ������Ƿ�˰
	salesPrice money,				--���۵���
	salesincludeTax bit,			--���۵����Ƿ�˰
	unit char(2),					--��λ
	inventoryQuantity int,			--�������
	lastWarehousing datetime,		--���һ�����ʱ��
	stockOperatorID nvarchar(20),	--����Ա���
)
go

--�����
drop table finance
go
create table finance
(
	financialNumber nvarchar(30),		  --������
	internalOrderNumber nvarchar(30),	  --�ڲ�������
	paymentDate datetime,				  --���񸶿�����
	paymentAmount money,				  --������
	paymentRemark nvarchar(100),		  --��ע
	financeOperatorID nvarchar(20),		  --����Ա���
)
go

--�����
drop table outgoing
go
create table outgoing
(
	outgoingNumber int identity(1,1),			  --������
	officialOrderNumber nvarchar(50),			  --�ͻ������ţ���ʽ�����ţ�
	outgoingcustomerID int,						  --�ͻ����
	outgoingproductID nvarchar(30),				  --��Ʒ���
	outgoingQuantity int,						  --��������
	outgoingDiscount float check(outgoingDiscount between 0.1 and 1), --�ۿ�
	includeTax bit,								  --�Ƿ�˰
	deliveryExpressnumber nvarchar(50),			  --������ݵ���
	deliveryExpressCompany nvarchar(20),		  --������ݹ�˾
	deliveryTime datetime,						  --����ʱ��
	outgoingOperatorID nvarchar(20),			  --����Ա���
	outgoingRemark nvarchar(100),				  --��ע
	outgoingState bit,							  --���״̬
)
go
select * from userinfo
--�û���Ϣ��
drop table userinfo
go
create table userinfo
(
	userNumber int identity(1,1),		  --�û����
	loginNumber nvarchar(20) unique,	  --��¼�˺�
	loginPwd nvarchar(max),				  --�û�����
	userRights int,						  --�û�Ȩ��
	userStatus bit,						  --�û�״̬
	userOperatorID nvarchar(20),		  --����Ա���
)
go

--�û���˽�����ܣ�
drop table userprivacy
go
create table userprivacy
(
	userNumber int,							   --�û����
	userName nvarchar(20),					   --�û�����
	userNativeplace nvarchar(20),			   --����
	userGender bit,							   --�Ա�
	userMarriage bit,						   --����
	userNation nvarchar(20),				   --����
	userBirth datetime,						   --��������
	userPolitical nvarchar(20),				   --������ò
	userFamilysituation nvarchar(200),		   --��ͥ���
	userHomeaddress nvarchar(200),			   --��ͥסַ
	userContactinfo nvarchar(50),			   --��ϵ��ʽ
	userPhotoURL nvarchar(max),				   --����ͷ��URL
	userMonologue nvarchar(max),			   --���˶���
)
go

--�û�Ȩ�ޱ�
drop table rights
go
create table rights
(
	rightsLevel int identity(1,1),	 --Ȩ�޵ȼ�
	rightsName nvarchar(20),		 --Ȩ������
	rightsRemark nvarchar(100),		 --Ȩ�ޱ�ע
)
go

--�ͻ���Ϣ��
drop table customerinfo
go
create table customerinfo
(
	customerNumber int identity(1,1),						 --�ͻ����
	customerName nvarchar(20),								 --�ͻ�����
	customerGender bit,										 --�ͻ��Ա�
	customerCompany nvarchar(50),							 --��˾����
	customerContactinfo nvarchar(20),						 --��ϵ��ʽ
	customerContactAddress nvarchar(100),					 --��ϵ��ַ
	customerRemark nvarchar(100),							 --��ע
	customerStatus bit,										 --�û�״̬
	customerOperatorID nvarchar(20),						 --����Ա���
)
go

--��Ӧ�̱�
drop table supplier
go
create table supplier
(
	supplierNumber int identity(1,1),	   --��Ӧ�̱��
	supplierName nvarchar(20),			   --��Ӧ������
	supplierInfo nvarchar(100),			   --��Ӧ����Ϣ
	supplierRemark nvarchar(200),		   --��ע
	supplierStatus bit,					   --��Ӧ��״̬
	supplierIperatorID nvarchar(20),	   --����Ա���
)
go

--ά�ޱ�
drop table repair
go
create table repair
(
	repairCustomernumber int,					  --�ͻ����
	repairProductID nvarchar(30),				  --��Ʒ���
	repairSNCode nvarchar(30),					  --S/N��
	repairMeg nvarchar(100),					  --ά��ԭ��
	repairName nvarchar(20),					  --ά��������
	repairArrivalTime datetime,					  --�ջ�����
	repairExpressNumber nvarchar(50),			  --�ջ���ݵ���
	repairExpressCompany nvarchar(20),			  --�ջ���ݹ�˾����
	repairContacts nvarchar(30),				  --��ϵ������
	repairContactinfo nvarchar(20),				  --��ϵ��ʽ
	repairContactAddress nvarchar(100),			  --��ϵ��ַ
	repairReturnTime datetime,					  --�黹����
	repairReturnExpressNumber nvarchar(50),		  --�黹��ݵ���
	repairReturnExpressCompany nvarchar(20),	  --�黹��ݹ�˾����
	repairReturnSNCode nvarchar(30),			  --��S/N��
	repairOperatorID nvarchar(20),				  --�����˱��
	repairStatus bit,							  --���״̬
)
go

--�����
drop table borrow
go
create table borrow
(
	borrowNumber int identity(1,1),		   --������
	borrowProductID nvarchar(30),		   --��Ʒ���
	borrowSNCode nvarchar(30),			   --S/N��
	borrowQuantity int,					   --����
	borrower nvarchar(20),				   --�����
	borrowOperatorID nvarchar(20),		   --����Ա���
	borrowTime datetime,				   --���ʱ��
	borrowReturnTime datetime,			   --�黹ʱ��
	IsReturn bit,						   --�Ƿ�黹
	borrowRemark nvarchar(100),			   --��ע
	borrowStatus bit,					   --���״̬
)
go

--�½��
drop table monthlyknot
go
create table monthlyknot
(
	monthlyKnotNumber int identity(1,1),	--�½���
	monthlyKnotProductID nvarchar(30),		--��Ʒ���
	beginmonthNumber int,					--�³�����
	monthlyInput int,						--�����������
	monthlyOutput int,						--���·�������
	endmonthNumber int,						--��ĩ����
	thismonth datetime,						--��ǰ����
)
go