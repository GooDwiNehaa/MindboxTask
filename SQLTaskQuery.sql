CREATE DATABASE MindboxTask;
GO
USE MindboxTask;
GO

CREATE TABLE Products(
	Id INT IDENTITY(1, 1) NOT NULL,
	ProductName NVARCHAR(30) NOT NULL,
	
	CONSTRAINT PK_Products_Id PRIMARY KEY CLUSTERED (Id)	
);

CREATE TABLE Categories(
	Id INT IDENTITY(1, 1) NOT NULL,
	CategoryName NVARCHAR(30) NOT NULL,
	
	CONSTRAINT PK_Categories_Id PRIMARY KEY CLUSTERED (Id)	
);

CREATE TABLE ProductsCategories(
	ProductId INT NOT NULL,
	CategoryId INT NOT NULL,
	
	CONSTRAINT PK_ProductsCategories_Ids PRIMARY KEY CLUSTERED (ProductId, CategoryId),
	CONSTRAINT FK_ProductsCategories_ProductId FOREIGN KEY (ProductId) REFERENCES Products (Id),
	CONSTRAINT FK_ProductsCategories_CategoryId FOREIGN KEY (CategoryId) REFERENCES Categories (Id)
);
GO

INSERT INTO Products(ProductName)
VALUES
	(N'Молоко'),
	(N'Мажитэль'),
	(N'Молочный коктейль Чудо'),
	(N'Сыр'),
	('Evervess'),
	('Fanta'),
	(N'Банан'),
	(N'Пирог');

INSERT INTO Categories (CategoryName)
VALUES 
	(N'Напитки'),
	(N'Молочные продукты');
	
INSERT INTO ProductsCategories(
	ProductId,
	CategoryId
)
VALUES
	(1, 2),
	(2, 1),
	(2, 2),
	(3, 1),
	(3, 2),
	(4, 2),
	(5, 1),
	(6, 1);
GO

SELECT p.ProductName + ' - ' + ISNULL(c.CategoryName, 'Категория отсутствует') AS Result
FROM Products AS p
LEFT JOIN ProductsCategories AS pc ON p.Id = pc.ProductId
LEFT JOIN Categories AS c ON pc.CategoryId = c.Id
ORDER BY p.ProductName