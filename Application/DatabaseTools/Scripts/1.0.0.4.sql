/* Add ID to PaymentStaging */
select *
into PaymentStaging_Temp
from PaymentStaging
go

drop table PaymentStaging
go

create table PaymentStaging (
	ID integer identity(1, 1) not null,
	Username nvarchar(15) references Users(Username) not null,
	SupplierId int references Suppliers(SupplierId) not null,
	Amount numeric(15, 2) not null,
	primary key (ID)
)
go

insert into PaymentStaging
select Username, SupplierId, Amount
from PaymentStaging_Temp
go

select *
from PaymentStaging
/********************************************************************/

if OBJECT_ID('SystemParameters', 'U') is not null alter table SystemParameters add HideSensitiveSupplierFields smallint default 0
go

UPDATE SystemParameters
SET DatabaseVersion = '1.0.0.4'
GO