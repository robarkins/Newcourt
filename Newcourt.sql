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
		BankAccountID integer identity(1, 1) not null,
		BankAccountName nvarchar(70) not null,
		BIC nvarchar(11) not null,
		IBAN nvarchar(35) not null,
		OIN nvarchar(35) not null,
		primary key(BankAccountID)
	)

	go

	create table Payments (
		PaymentID integer identity(1, 1) not null,
		SupplierID integer references Suppliers(SupplierID) not null,
		BankAccountID integer references BankAccounts(BankAccountID) not null,
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

	insert into Users
	select 'Admin', 'Admin', 1, null

	go
