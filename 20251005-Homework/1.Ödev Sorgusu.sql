create Database MyNorthwind
use MyNorthwind
create Table Kampanya(KampanyaID INT PRIMARY KEY IDENTITY(1,1)
,KampanyaAdı NVARCHAR(100),
IndirimOrani DECIMAl(5,2),
BaslangicTarihi Date,
BitisTarihi Date);

INSERT INTO Kampanya (KampanyaAdı, IndirimOrani, BaslangicTarihi, BitisTarihi)
VALUES
('3 Alana 1 Bedava', 0.33, '2025-10-17', '2025-10-31');

INSERT INTO Kampanya (KampanyaAdı, IndirimOrani, BaslangicTarihi, BitisTarihi)
VALUES
('Kış Festivali', 0.20, '2025-12-01', '2025-12-31');

INSERT INTO Kampanya (KampanyaAdı, IndirimOrani, BaslangicTarihi, BitisTarihi)
VALUES
('Eylül Fırsatı', 0.15, '2025-09-01', '2025-09-30');

UPDATE Kampanya
SET IndirimOrani = 0.25
WHERE KampanyaAdı = 'Kış Festivali';


DELETE FROM Kampanya
WHERE KampanyaAdı = 'Eylül Fırsatı';


