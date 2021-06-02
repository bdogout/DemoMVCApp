CREATE TABLE [dbo].[ProductTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductSKU] NVARCHAR(50) NOT NULL, 
    [ProductClassification] NVARCHAR(50) NOT NULL, 
    [ProductPrice] MONEY NOT NULL, 
    [ProductInStock] INT NULL, 
    [ProductBrand] NVARCHAR(50) NOT NULL
)
