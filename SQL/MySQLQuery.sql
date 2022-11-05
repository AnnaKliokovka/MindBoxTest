CREATE TABLE Products(
	ProductID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	ProductName varchar(50) NOT NULL
);

INSERT INTO Products (ProductName) VALUES ('Молоко'), ('Творог'), ('Печенье'), ('Арахис');

CREATE TABLE Categories(
	CategoryID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	CategoryName varchar(50) NOT NULL
);

INSERT INTO Categories (CategoryName) VALUES ('Молочные продукты'), ('Бакалея'), ('Полезные продукты');

CREATE TABLE ProductsAndCategories(
	ProductID INT NOT NULL,
	CategoryID INT NOT NULL,
	FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
	FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID),
	PRIMARY KEY(ProductID,CategoryID)
);

INSERT INTO ProductsAndCategories
VALUES
	(1, 1),
	(1, 3),
	(2, 1),
	(2, 3),
	(3, 2);
	
SELECT P."ProductName", C."CategoryName"
FROM Products P
LEFT JOIN ProductsAndCategories PC
	ON P.ProductId = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.CategoryId;