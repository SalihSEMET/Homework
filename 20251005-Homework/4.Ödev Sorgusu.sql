use Northwind
SELECT
    ProductName,
    UnitPrice
FROM
    Products
WHERE
    UnitPrice = (SELECT MAX(UnitPrice) FROM Products);


CREATE VIEW vw_TopCustomers AS
SELECT TOP 10
    Customers.CompanyName AS MusteriAdi,
    COUNT(Orders.OrderID) AS ToplamSiparisSayisi
FROM
    Customers
INNER JOIN
    Orders ON Customers.CustomerID = Customers.CustomerID
GROUP BY
    Customers.CustomerID, Customers.CompanyName
ORDER BY
    ToplamSiparisSayisi DESC;