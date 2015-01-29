-----------------------------------------------------------------------
------------------------ TABLES ---------------------------------------

create table SupplierTypes 
(
	SupplierTypeCode nvarchar(15) not null,
	Name nvarchar(70),
	primary key (SupplierTypeCode)
)

go

create table Suppliers 
(
	SupplierID integer identity(1, 1) not null,
	SupplierTypeCode nvarchar(15) references SupplierTypes(SupplierTypeCode),
	FirstName nvarchar(70) not null,
	Surname nvarchar(70),
	Address1 nvarchar(70),
	Address2 nvarchar(70),
	Address3 nvarchar(70),
	Address4 nvarchar(70),
	Address5 nvarchar(70),
	Phone nvarchar(70),
	Mobile nvarchar(70),
	PPSVat nvarchar(15) not null,
	BankName nvarchar(70) not null,
	BankAddress1 nvarchar(70),
	BankAddress2 nvarchar(70),
	BankAddress3 nvarchar(70),
	BankAddress4 nvarchar(70),
	BankAddress5 nvarchar(70),
	BankAccNumber nvarchar(15) not null,
	SortCode nvarchar(15) not null,
	BIC nvarchar(11) not null,
	IBAN nvarchar(35) not null,
	primary key (SupplierID)
)

go

create table Users (
	Username nvarchar(15) not null,
	Password nvarchar(15) not null,
	IsAdmin tinyint default 0 not null,
	LastLoggedIn datetime,
	primary key (Username)
)

go

create table BankAccounts (
	BankAccountCode nvarchar(15) not null,
	BankAccountName nvarchar(70) not null,
	BIC nvarchar(11) not null,
	IBAN nvarchar(35) not null,
	OIN nvarchar(35) not null,
	primary key(BankAccountCode)
)

go

create table Payments (
	PaymentID integer identity(1, 1) not null,
	SupplierID integer references Suppliers(SupplierID) not null,
	BankAccountCode nvarchar(15) references BankAccounts(BankAccountCode) not null,
	Username nvarchar(15) references Users(Username) not null,
	Amount numeric(15, 2) not null,
	TimeProcessed datetime,
	primary key (PaymentID)
)

go

create table SystemParameters (
	ID integer not null,
	DatabaseVersion nvarchar(20),
	CompanyName nvarchar(70)
	primary key (ID)
)

go

create table PaymentStaging (
	Username nvarchar(15) references Users(Username) not null,
	SupplierId int references Suppliers(SupplierId) not null,
	Amount numeric(15, 2) not null,
	primary key (Username, SupplierId)
)

go

-----------------------------------------------------------------------
------------------------ STORED PROCEDURES ----------------------------

if object_id('GenerateSEPAPaymentXML') is not null
	drop procedure GenerateSEPAPaymentXML

go

create procedure GenerateSEPAPaymentXML
(
	@BankAccountCode nvarchar(15),
	@PaymentDate datetime,
	@Username nvarchar(15)
)
as 
begin

	declare @date datetime
	declare @msgId nvarchar(25)
	declare @oin nvarchar(35)
	declare @bic nvarchar(11)
	declare @iban nvarchar(35)
	declare @xml xml

	set @date = GETDATE()
	set @msgId = 'SEPA-' + RIGHT('00' + CONVERT(nvarchar(2), DAY(@date)), 2) + '.' +
						 + RIGHT('00' + CONVERT(nvarchar(2), MONTH(@date)), 2) + '.' +
						 + CONVERT(nvarchar(4), YEAR(@date)) + '-' +
						 + RIGHT('00' + CONVERT(varchar(2), DATEPART(HOUR, @date)), 2) + ':' +
						 + RIGHT('00' + CONVERT(varchar(2), DATEPART(MINUTE, @date)), 2)


	select @bic = BIC, @iban = IBAN, @oin = OIN
	from BankAccounts
	where @BankAccountCode = @BankAccountCode

	set @xml = (
	select '' [@ns],
		(select @msgId [GrpHdr/MsgId],
				CONVERT(nvarchar(30), @date, 126) [GrpHdr/CreDtTm],
				count(a.PaymentID) [GrpHdr/NbOfTxs],
				sum(a.Amount) [GrpHdr/CtrlSum],
				@oin [GrpHdr/InitgPty/Id/OrgId/Othr/Id],
				(select @msgId [PmtInfId],
						'TRF' [PmtMtd],
						count(a.PaymentID) [NbOfTxs],
						sum(a.Amount) [CtrlSum],
						'SEPA' [PmtTpInf/SvcLvl/Cd],
						CONVERT(nvarchar(10), @PaymentDate, 126) [ReqdExctnDt],
						b.CompanyName [Dbtr/Nm],
						@iban [DbtrAcct/Id/IBAN],
						'EUR' [DbtrAcct/Ccy],
						@bic [DbtrAgt/FinInstnId/BIC],
						(select 'Supplier Payment - ' + c.FirstName + ' ' + c.Surname [PmtId/EndToEndId],
						 'EUR' [Amt/InstdAmt/@Ccy],
						 d.Amount [Amt/InstdAmt],
						 c.BIC [CdtrAgt/FinInstnId/BIC],
						 c.Surname + ', ' + c.FirstName [Cdtr/Nm],
						 c.IBAN [CdtrAcct/Id/IBAN],
						 'EUR' [CdtrAcct/Ccy]
						 from Suppliers c
						 inner join Payments d on (c.SupplierID = d.SupplierID)
						 where d.Username = @Username and d.TimeProcessed is null
						for xml path('CdtTrfTxInf'), type)
						from SystemParameters b
				for xml path('PmtInf'), type)
		 from Payments a
		 where a.Username = @Username and a.TimeProcessed is null
		for xml path('CstmrCdtTrfInitn'), type)
	for xml path('Document'))

	update Payments set TimeProcessed = @date where Username = @Username and TimeProcessed is null
	delete from PaymentStaging where Username = @Username

	select '<?xml version="1.0" encoding="UTF-8"?>' + replace(convert(nvarchar(max), @xml), '<Document ns="">', '<Document xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns="urn:iso:std:iso:20022:tech:xsd:pain.001.001.03">')

end

go

-----------------------------------------------------------------------
------------------------ INSERTS --------------------------------------

insert into Users
select 'Admin', 'Admin', 1, null

go
