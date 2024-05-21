-- Создаём таблицу Products
CREATE TABLE Products 
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Title NVARCHAR(30)
)

-- Создаём таблицу Categories
CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Title NVARCHAR(30)
)

-- Создаём таблицу ProductCategories для организации связи много-ко-многим
CREATE TABLE ProductCategories
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	ProductId INT REFERENCES Products(Id),
	CategoryId INT REFERENCES Categories(Id),
)

-- Заполняем таблицы значениями
INSERT INTO Products (Title) VALUES ('Product1'), ('Product2'), ('Product3'), ('Product4'), ('Product5'), ('Product6'), ('Product7'), ('Product8'), ('Product9'), ('Product10')
INSERT INTO Categories (Title) VALUES ('Category1'), ('Category2'), ('Category3')
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (1, 2), (2, 2), (3, 1), (4, 1), (10, 1), (10, 2), (10, 3)

-- Выборка всех пар "Имя продукта - Имя категории"
SELECT product.[Title] AS ProductTitle,
    [Categories].[Title] AS CategoryTitle
FROM [Products] AS product
    LEFT JOIN [ProductCategories] ON [ProductCategories].ProductId = product.Id
    LEFT JOIN [Categories] ON [Categories].Id = [ProductCategories].CategoryId;