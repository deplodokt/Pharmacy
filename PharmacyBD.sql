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
values	('Главфарм','Главфарм','123'),
		('АСОКА','АСОКА','111'),
		('Биоритм','Биоритм','111'),
		('Аспект','Аспект','222')
		

insert into dbo.Seller 
values	('Иван','Иванов','Иван','123'),
		('Петр','Васильевич','Петр','222')


insert into dbo.Administration
values ('Admin','Admin')

insert into dbo.Medication 
values	('Аевит',		'45645685','2021-03-12','2022-03-12',12.5,'Не нужен',100,6),
		('Неуробекс',	'47869524','2021-04-25','2022-04-25',10,'Не нужен',80,5),
		('Ксилин',		'78935556','2021-05-15','2022-03-15',8,'Не нужен',90,6),
		('Ксило-назал',	'15646468','2021-02-22','2022-01-22',5.6,'Нужен',70,7),
		('Моторикум',	'79845431','2021-02-26','2022-04-26',15.5,'Нужен',50,7),
		('Мукоделит',	'35479872','2021-01-24','2022-05-24',12,'Не нужен',120,8),
		('Омнификс',	'78924313','2021-02-10','2022-01-10',18,'Нужен',100,8),
		('Оптик гард',	'34578797','2021-01-09','2022-03-09',20,'Не нужен',180,5),
	   ('Палора ультра','79813212','2021-02-12','2022-04-12',13.8,'Нужен',90,6),
		('Формула спокойствия',	'34578797','2021-01-09','2022-03-09',20.2,'Не нужен',50,5),
		('Фотолон',							'46548645','2021-03-23','2023-03-23',13,'Нужен',30,7),
		('Фукус',							'87984565','2021-04-13','2022-04-13',4,'Нужен',20,8),
		('Шиповника сироп',					'34678798','2021-02-18','2021-03-10',9,'Не нужен',45,5),
		('Эплан',							'34789789','2021-01-20','2023-04-15',32.2,'Не нужен',43,6),
		('Камистад',						'35787998','2021-04-23','2024-03-19',31,'Не нужен',80,7),
		('Канверс',							'35487878','2021-06-02','2021-10-17',41.1,'Нужен',150,8),
		('Капилар',							'37879454','2021-02-01','2022-11-09',2.41,'Не нужен',80,8)



drop table dbo.Medication
drop table dbo.CatalogMedication

--insert into dbo