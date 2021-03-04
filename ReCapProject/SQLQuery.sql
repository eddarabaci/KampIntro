Create Table Cars
( Id int Primary Key Identity(1,1) ASC,
BrandId int,
ColorId int,
ModelYear nvarchar(25),
DailyPrice decimal,
Descriptions nvarchar(25),
Foreign key (BrandID) references Brands(BrandID),
Foreign key (ColorId) references Colors(ColorID)
)

Create table Colors(
ColorId int primary key identity(1,1),
ColorName nvarchar(25),
)
Create table Brands(
BrandId int primary key identity(1,1),
BrandName nvarchar(25),

)

Create Table Users( 
UserId int Primary Key Identity(1,1),
FirstName nvarchar(40),
LastName nvarchar(40),
Email nvarchar(60),
Password nvarchar(25),
)

Create Table Customers( 
CustomerId int Primary Key Identity(1,1),
UserId int,
CompanyName nvarchar(40),
Foreign key (UserId) references Users(UserId)
)

Create Table Rentals( 
RentalId int Primary Key Identity(1,1),
CarId int,
CustomerId int,
RentDate datetime,
ReturnDate datetime NULL,
Foreign key (CarId) references Cars(Id),
Foreign key (CustomerId) references Customers(CustomerId)
)

Insert Into [dbo].[Cars](BrandId,ColorId,DailyPrice,ModelYear,Descriptions)
Values
	('1','1','150','2017','Opel Astra Otomatik'),
    ('2','3','300','2012','Mercedes Benz'),
    ('3','2','170','2018','Peugeot 208 1.2 Dizel'),
    ('3','1','250','2020','Peugeot 2008 SUV Benzin'),
    ('4','2','190','2016','Toyota Yaris Hibrid');


Insert Into [dbo].[Colors](ColorName)
Values
	('Beyaz'),('Siyah'),('Gri');

Insert Into [dbo].Brands(BrandName)
Values
	('Opel'),('Mercedes'),('Peugeot'),('Toyota');


Insert Into [dbo].[Users](FirstName,LastName,Email,Password)
Values
	('Can','Pehlivan','can.pehlivan@canmail.com','can123'),
    ('Ece','Soysal','ece.soysal@ecemail.com','ece123'),
    ('Suna','Karakoyun','suna.karakoyun@sunamail.com','suna123');

Insert Into [dbo].[Customers](UserId,CompanyName)
Values
	('1','Arabanız Hazır'),
    ('2','Rent A Car'),
    ('3','Araç Kapında');

Insert Into [dbo].[Rentals](CarId,CustomerId,RentDate,ReturnDate)
Values
	('1','1','1/8/2021','1/12/2021'),
    ('2','2','1/15/2021',NULL),
    ('3','3','1/22/2021','1/27/2021');

Select * from Cars
Select * from Brands
Select * from Colors