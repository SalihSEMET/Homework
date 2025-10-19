use Northwind
CREATE TABLE OrderLogs (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT NOT NULL,
    SilinmeTarihi DATETIME DEFAULT GETDATE()
);

GO

CREATE TRIGGER trg_LogAfterDeleteOrder
ON Orders
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO OrderLogs (OrderID, SilinmeTarihi)
    SELECT
        OrderID,
        GETDATE()
    FROM
        deleted;
END;

GO

CREATE TRIGGER trg_PreventExcessivePriceIncrease
ON Products
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF UPDATE(UnitPrice)
    BEGIN
        IF EXISTS (
            SELECT 1
            FROM inserted AS i
            INNER JOIN deleted AS d ON i.ProductID = d.ProductID
            WHERE
                i.UnitPrice > (d.UnitPrice * 1.50)
        )
        BEGIN
            RAISERROR ('Ürün Fiyatı %50''Den Fazla Arttırılamaz.', 16, 1);
            ROLLBACK TRANSACTION;
        END
    END
END;

GO