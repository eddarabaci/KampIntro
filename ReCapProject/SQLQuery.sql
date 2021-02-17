Create Table Cars
( Id int Primary Key Identity(1,1),
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

Select * from Cars
Select * from Brands
Select * from Colors