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

UPDATE SystemParameters
SET DatabaseVersion = '1.0.0.3'
GO