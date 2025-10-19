use Northwind
SELECT
    MusteriAdi,
    ToplamSiparisSayisi,
    CASE
        WHEN ToplamSiparisSayisi = (
            SELECT MAX(SiparisSayisi)
            FROM (
                SELECT COUNT(OrderID) AS SiparisSayisi
                FROM Orders
                GROUP BY CustomerID
            ) AS AltSiparisSorgusu
        )
        THEN '*** Bu müşteri VIP ilan edilmiştir! ***'
        ELSE 'Standart Müşteri'
    END AS MusteriDurumu
FROM
    (
        SELECT
            C.CompanyName AS MusteriAdi,
            COUNT(O.OrderID) AS ToplamSiparisSayisi
        FROM
            Customers AS C
        INNER JOIN
            Orders AS O ON C.CustomerID = O.CustomerID
        GROUP BY
            C.CustomerID, C.CompanyName
    ) AS MusteriSiparisleri
ORDER BY
    ToplamSiparisSayisi DESC;