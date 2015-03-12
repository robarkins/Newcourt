IF OBJECT_ID('Suppliers', 'U') IS NOT NULL BEGIN

	alter table Suppliers
	alter column PPSVat nvarchar(15)

  alter table Suppliers
	alter column BankAccNumber nvarchar(15)

END
GO

UPDATE SystemParameters
SET DatabaseVersion = '1.0.0.2'
GO