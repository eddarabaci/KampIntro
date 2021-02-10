--Select
Select ContactName adi,CompanyName sirketadi,City sehir from Customers
Select * from Customers where City = 'Berlin'

--case insansitive
sELECT * from Products where categoryId = 1 or CategoryID =3
sELECT * from Products where categoryId = 1 or UnitPrice > 10

select * from Products order by CategoryID, ProductName

--Bir e ticaret uygulamasında urunler içerisinde kategorilerde kitap seçip fiyata göre azalan sirala demek
select * from Products where CategoryID=1 order by UnitPrice desc   --ascending  --descending

--Katalogumuzda kaç cesit urun besliyoruz
select count(*) from Products
select count(*) Adet from Products where CategoryID = 2

--hangi kategoride kac farklı urun var
--group by yapıldığında her bir category için arkada farklı tablo oluşuyor gibi düşünülebilir
select CategoryID, count(*) Adet from Products group by CategoryID

--urun sayisi 10dan az olan kategorileri listele
select CategoryID, count(*) Adet from Products group by CategoryID having count(*)<10

--birim fiyatı 20den fazla olan urunleri categoryIdye gore grupla onlardan da sayısı 10dan az olanları getir
-- Products where UnitPrice>20,  group by CategoryID, having count(*)<10
select CategoryID, count(*) Adet from Products where UnitPrice>20 group by CategoryID having count(*)<10

--son kullanıcı urunleri filtrelediginde categoryID görmez, categoryName görür bu sebeple 2 tabloyu bir araya getirmek gerekir
--inner join sadece iki tabloda da eşleşenleri bir araya getirir, eslesmeyen data varsa onu getirmez
select * 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID   --neye gore join diyoruz

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName --görmek istediğimiz kolonlar
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID   

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 10  --> Fiyatı 10Dan buyuk urunlerin categoryName ile birlikte sıralanması

--left join solda olup sağda olmayanları da getir, yani ürünlerde var ama satışı yok
select *
from Products p left join [Order Details] od
on p.ProductID = od.ProductID

--uzunca süredir alışveriş yapmayan ya da ilk kez üye olmuş henüz alışveriş yapmayanlar, e-ticarette sana özel popup'ı sorgusu gibi düşünülebilir
select *
from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null