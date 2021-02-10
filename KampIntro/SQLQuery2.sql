Select p.ProductName UrunAdi,SUM(od.UnitPrice*od.Quantity) KazanilanToplamMiktar
from Products p 
inner join [Order Details] od on od.ProductID = p.ProductID
inner join Orders o on od.OrderID = o.OrderID
group by p.ProductName 
order by KazanilanToplamMiktar desc