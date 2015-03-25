IF OBJECT_ID('BankIdentifierCodes', 'U') IS NULL BEGIN

	create table BankIdentifierCodes (
		ID integer identity(1, 1) NOT NULL,
		Code nvarchar(11) NOT NULL,
		primary key (ID)
	)
	
END
GO

IF NOT EXISTS (SELECT * FROM BankIdentifierCodes WHERE Code = 'AIBKIE2D')
	INSERT INTO BankIdentifierCodes SELECT 'AIBKIE2D'
GO

IF NOT EXISTS (SELECT * FROM BankIdentifierCodes WHERE Code = 'BOFIIE2D')
	INSERT INTO BankIdentifierCodes SELECT 'BOFIIE2D'
GO

IF NOT EXISTS (SELECT * FROM BankIdentifierCodes WHERE Code = 'BARCIE2D')
	INSERT INTO BankIdentifierCodes SELECT 'BARCIE2D'
GO

IF NOT EXISTS (SELECT * FROM BankIdentifierCodes WHERE Code = 'EBSIIE2D')
	INSERT INTO BankIdentifierCodes SELECT 'EBSIIE2D'
GO

IF NOT EXISTS (SELECT * FROM BankIdentifierCodes WHERE Code = 'IPBSIE2D')
	INSERT INTO BankIdentifierCodes SELECT 'IPBSIE2D'
GO

IF NOT EXISTS (SELECT * FROM BankIdentifierCodes WHERE Code = 'ULSBIE2D')
	INSERT INTO BankIdentifierCodes SELECT 'ULSBIE2D'
GO

IF NOT EXISTS (SELECT * FROM BankIdentifierCodes WHERE Code = 'MDCIIE21XXX')
	INSERT INTO BankIdentifierCodes SELECT 'MDCIIE21XXX'
GO

IF COL_LENGTH('SystemParameters', 'PaymentRef') IS NULL
	ALTER TABLE SystemParameters ADD PaymentRef NVARCHAR(128)
GO

if object_id('GenerateSEPAPaymentXML', 'P') is not null
	drop procedure GenerateSEPAPaymentXML
go

create procedure GenerateSEPAPaymentXML
(
	@BankAccountCode nvarchar(15),
	@PaymentDate datetime,
	@PaymentRef nvarchar(128),
	@Username nvarchar(15),
	@Batch integer output
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
				count(a.SupplierId) [GrpHdr/NbOfTxs],
				sum(a.Amount) [GrpHdr/CtrlSum],
				@oin [GrpHdr/InitgPty/Id/OrgId/Othr/Id],
				(select @msgId [PmtInfId],
						'TRF' [PmtMtd],
						count(a.SupplierId) [NbOfTxs],
						sum(a.Amount) [CtrlSum],
						'SEPA' [PmtTpInf/SvcLvl/Cd],
						CONVERT(nvarchar(10), @PaymentDate, 126) [ReqdExctnDt],
						b.CompanyName [Dbtr/Nm],
						@iban [DbtrAcct/Id/IBAN],
						'EUR' [DbtrAcct/Ccy],
						@bic [DbtrAgt/FinInstnId/BIC],
						(select 'SEPA Payment - ' + c.FirstName + ' ' + c.Surname [PmtId/EndToEndId],
						 'EUR' [Amt/InstdAmt/@Ccy],
						 d.Amount [Amt/InstdAmt],
						 c.BIC [CdtrAgt/FinInstnId/BIC],
						 c.Surname + ', ' + c.FirstName [Cdtr/Nm],
						 c.IBAN [CdtrAcct/Id/IBAN],
						 'EUR' [CdtrAcct/Ccy]
						 from Suppliers c
						 inner join PaymentStaging d on (c.SupplierID = d.SupplierID)
						 where d.Username = @Username
						for xml path('CdtTrfTxInf'), type)
						from SystemParameters b
				for xml path('PmtInf'), type)
		 from PaymentStaging a
		 where a.Username = @Username
		for xml path('CstmrCdtTrfInitn'), type)
	for xml path('Document'))
	
	--select @xml
	
	select @Batch = coalesce(MAX(Batch), 0) + 1
	from Payments
	
	insert into Payments
	(SupplierID, BankAccountCode, Username, Amount, TimeProcessed, Batch)
	select SupplierId, @BankAccountCode, @Username, Amount, GETDATE(), @Batch
	from PaymentStaging
	
	delete from PaymentStaging where Username = @Username
	update SystemParameters set SepaFileCount = coalesce(SepaFileCount, 0) + 1, PaymentRef = @PaymentRef

	select '<?xml version="1.0" encoding="UTF-8"?>' + replace(convert(nvarchar(max), @xml), '<Document ns="">', '<Document xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns="urn:iso:std:iso:20022:tech:xsd:pain.001.001.03">')

end
go

UPDATE SystemParameters
SET DatabaseVersion = '1.0.0.3'
GO