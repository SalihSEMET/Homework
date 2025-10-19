use Northwind

Select TOP(5) * from Products order by UnitPrice desc

SELECT
  Orders.ShipCountry,
  "Order Details".Quantity * "Order Details".UnitPrice
FROM Orders
JOIN "Order Details" ON Orders.OrderID = "Order Details".OrderID

SELECT
  Orders.ShipCountry,
  SUM("Order Details".Quantity * "Order Details".UnitPrice) AS ToplamSatis
FROM Orders
JOIN "Order Details" ON Orders.OrderID = "Order Details".OrderID
GROUP BY Orders.ShipCountry order by ToplamSatis desc

SELECT
  ShipCountry,
  COUNT(*) AS ToplamSiparisSayisi
FROM Orders
GROUP BY ShipCountry

SELECT TOP(1)
EmployeeID,
COUNT(*) AS ToplamSatisAdedi
from Orders
group by EmployeeID order by ToplamSatisAdedi desc 
