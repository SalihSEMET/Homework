use Northwind

SELECT
    Customers.CompanyName AS MusteriAdi,
    Orders.OrderDate AS SiparisTarihi
FROM
    Customers
INNER JOIN
    Orders ON Customers.CustomerID = Orders.CustomerID
ORDER BY
    MusteriAdi, SiparisTarihi;


SELECT
    ProductID,
    UnitPrice,
    CASE
        WHEN UnitPrice <= 10 THEN 'Ucuz'
        WHEN UnitPrice > 10 AND UnitPrice <= 30 THEN 'Orta'
        ELSE 'Pahalı'
    END AS FiyatKategorisi
FROM
    [Order Details];
