CREATE PROCEDURE sp_MusteriSiparisleri
    @MusteriID nchar(5)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        C.CompanyName,
        O.OrderID,
        O.OrderDate,
        O.ShipCity,
        O.ShipCountry
    FROM
        Orders AS O
    INNER JOIN
        Customers AS C ON O.CustomerID = C.CustomerID
    WHERE
        O.CustomerID = @MusteriID
    ORDER BY
        O.OrderDate DESC;
END;
GO  

CREATE PROCEDURE sp_UrunFiyatGuncelle
    @UrunID int,
    @YeniFiyat money
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE
        Products
    SET
        UnitPrice = @YeniFiyat
    WHERE
        ProductID = @UrunID;
END;