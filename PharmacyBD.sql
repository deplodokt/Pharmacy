create database PharmacyBD
go 

create table Seller(
IDSeller int identity(1,1),
LastName  nvarchar(20) not null,
FirstName nvarchar(20) not null,
LoginSeller nvarchar(8) not null,
PasswordSeller nvarchar(8) not null,
constraint IDSeller primary key (IDSeller),
constraint UQ_LoginSeller  unique  (LoginSeller)
)

create table Suppliers(
IDSuppliers int identity(1,1),
NameSuppliers nvarchar (25) not null,
LoginSuppliers nvarchar(8) not null,
PasswordSuppliers nvarchar(8) not null,
constraint IDSuppliers primary key (IDSuppliers),
constraint UQ_NameSuppliers unique  (NameSuppliers)
)

create table Medication(
IDMedication int identity(1,1),
NameMedication nvarchar(25) not null,
Barcode varchar(8) not null,
ProductionDate date not null,
ExperienceDate date not null,
Price float not null,
WhithReceipt nvarchar(10),
Quantity int not null,
IDSuppliers int,
constraint IDMedication primary key (IDMedication),
constraint UQ_NameMedication  unique  (NameMedication),
constraint FK_IDSuppliers FOREIGN KEY (IDSuppliers) REFERENCES Suppliers(IDSuppliers)ON DELETE CASCADE ON UPDATE CASCADE
)

create table CatalogMedication(
IDCatalogMedication int identity(1,1),
IDMedication int,
QuantityCatalogMedication int not null,
constraint IDCatalogMedication primary key (IDCatalogMedication),
constraint FK_IDMedication FOREIGN KEY (IDMedication) REFERENCES Medication(IDMedication)ON DELETE CASCADE ON UPDATE CASCADE
)

create table Administration(
IDAdministration int identity (1,1),
LoginAdministration nvarchar(8) not null,
PasswordAdministration nvarchar(8) not null,
constraint IDAdministration primary key (IDAdministration)

)

--create 

insert into dbo.Suppliers
values ('Главфарм','le','le')

insert into dbo.Seller 
values ('Иван','Иванов','123','123')

insert into dbo.Administration
values ('Admin','Admin')

insert into dbo.Medication 
values ('Nam','asd','2000-03-12','2000-03-12',12,'net',3),
		('Narew','asd','2000-03-12','2000-03-12',14,'net',3)


drop table dbo.Medication
drop table dbo.CatalogMedication

--insert into dbo