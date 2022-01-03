--To create the table of the customer
CREATE TABLE Customer(
CustomerID INT PRIMARY KEY IDENTITY,
CustomerFirstName nvarchar(25),
CustomerLastName nvarchar(25),
CustomerUserName nvarchar(25),
CustomerPassWord nvarchar(25)
);

--To create the table of the store
CREATE TABLE Store(
StoreID INT PRIMARY KEY,
StoreLocation nvarchar(25)
);

--To create the table of the product
CREATE TABLE Product(
ProductID INT PRIMARY KEY,
ProductPrice DECIMAL(6,2),
ProductName nvarchar(25),
ProductDescription nvarchar(50)
);

--To create the table of the inventory
CREATE TABLE Inventory(
StoreID INT FOREIGN KEY REFERENCES Store(StoreID),
ProductID INT FOREIGN KEY REFERENCES Product(ProductID),
ProductQuantity INT
);

--To create the customer orders
CREATE TABLE CustomerOrders(
OrderID INT PRIMARY KEY IDENTITY,
CustomerID INT FOREIGN KEY REFERENCES Customer(CustomerID),
StoreID INT FOREIGN KEY REFERENCES Store(StoreID), 
ProductID INT FOREIGN KEY REFERENCES Product(ProductID), 
ProductName nvarchar(25),
ProductQuantity INT,
ProductPrice DECIMAL(6, 2),
ProductTotal AS CONVERT(DECIMAL(6, 2), ProductQuantity* ProductPrice) 
);



--To create past orders
CREATE TABLE PastOrders(
PastOrderID INT PRIMARY KEY identity(1,1), --Unique primary key of all table
StoreID INT FOREIGN KEY REFERENCES Store(StoreID), --Where the product bought
CustomerID INT FOREIGN KEY REFERENCES Customer(CustomerID), --Who bought the product
ProductID INT FOREIGN KEY REFERENCES Product(ProductID), --What product was bought
OrderID uniqueidentifier NOT NULL, --The order of the product was bought in
ProductQuantity INT, -- How many bought
ProductPrice DECIMAL(6, 2), -- Unit price
ProductTotal AS CONVERT(DECIMAL(6, 2), ProductQuantity* ProductPrice) --ProductQuanitity * ProductPrice
);

CREATE TABLE TotalPastOrders(
TotalPastOrderID INT PRIMARY KEY identity(1,1), --Unique primary key of all table
StoreID INT FOREIGN KEY REFERENCES Store(StoreID), --Where the product bought
CustomerID INT FOREIGN KEY REFERENCES Customer(CustomerID), --Who bought the product
TotalPrice DECIMAL(4, 2), -- Unit price
TotalQuantity INT -- Total items price
);

SELECT * FROM TotalPastOrders;

INSERT INTO TotalPastOrders(StoreID, CustomerID, TotalPrice, TotalQuantity) VALUES (4, 2, 34.98, 2);


INSERT INTO PastOrders(StoreID,CustomerID,ProductID,OrderID,ProductQuantity,ProductPrice) VALUES(4,2,008,'a25a5cee-d6b2-432a-b764-57d99a452a12',2,10.99);
INSERT INTO PastOrders(StoreID,CustomerID,ProductID,OrderID,ProductQuantity,ProductPrice) VALUES(4,2,004,'a25a5cee-d6b2-432a-b764-57d99a452a12',1,4.99);
Drop Table PastOrders;
SELECT * FROM PastOrders;

--Insert table of customers
INSERT INTO Customer(CustomerFirstName, CustomerLastName, CustomerUserName, CustomerPassWord) VALUES('Elinor' , 'Peach', 'Opalmarigold', '10Daegu10');
INSERT INTO Customer(CustomerFirstName, CustomerLastName, CustomerUserName, CustomerPassWord) VALUES('Elizabeth' ,'Brown', 'Tourmalinecosmos', '1010Gwangju');
INSERT INTO Customer(CustomerFirstName, CustomerLastName, CustomerUserName, CustomerPassWord) VALUES('Emma' ,'Scarlet', 'LibraRowantree', 'Daejeon1010');
Drop Table Customer;
SELECT * FROM Customer;

--Insert table of store location
INSERT INTO Store(StoreId, StoreLocation) VALUES (1, 'Washington D.C.');
INSERT INTO Store(StoreId,StoreLocation) VALUES (2, 'Philadelphia');
INSERT INTO Store(StoreId,StoreLocation) VALUES (3, 'New York City');
INSERT INTO Store(StoreId,StoreLocation) VALUES (4, 'Boston');

SELECT * FROM Store;

--Insert table of products
INSERT INTO Product(ProductID, ProductName, ProductPrice, ProductDescription) VALUES(001,'White Rice', 17.99, '15 lbs of Rheechun Rice bag');
INSERT INTO Product(ProductID, ProductName, ProductPrice, ProductDescription) VALUES(002,'Ramen', 4.99, '4 packs of spicy Shin Ramen');
INSERT INTO Product(ProductID, ProductName, ProductPrice, ProductDescription) VALUES(003,'Soy Sauce', 10.99, '930 ml of Organic Sempio Soy Sauce');
INSERT INTO Product(ProductID, ProductName, ProductPrice, ProductDescription) VALUES(004,'Kimchi', 16.99, '3 lbs of Jongga Korean Cabbage Kimchi');
INSERT INTO Product(ProductID, ProductName, ProductPrice, ProductDescription) VALUES(005,'SoyBean Paste', 3.99, '15.9 oz of Sunchang SoyBean Paste');
INSERT INTO Product(ProductID, ProductName, ProductPrice, ProductDescription) VALUES(006,'Pancake Powder', 4.99, '2.2 lbs of Korean pancake mix powder');
INSERT INTO Product(ProductID, ProductName, ProductPrice, ProductDescription) VALUES(007,'Tofu', 2.99, '14 oz of Pulmuone Organic Tofu');
INSERT INTO Product(ProductID, ProductName, ProductPrice, ProductDescription) VALUES(008,'Dumpling', 10.99, '24 oz of CJ Beef Vegetable Dumpling');
INSERT INTO Product(ProductID, ProductName, ProductPrice, ProductDescription) VALUES(009,'Corn Syrup', 2.99, '24.7 oz of Chunjungone Corn syrup');
INSERT INTO Product(ProductID, ProductName, ProductPrice, ProductDescription) VALUES(010,'RedPepper Paste', 5.99, '1.1 lbs of Sunchang Red Pepper Paste');
INSERT INTO Product(ProductID, ProductName, ProductPrice, ProductDescription) VALUES(011,'Sesame Oil', 5.99, '370 oz of Ottogi Sesame Oil');
Drop Table Product;
SELECT * FROM Product;

--Insert table of inventory
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(1,001,50);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(1,002,40);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(1,003,36);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(1,004,25);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(1,005,34);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(1,006,25);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(1,007,48);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(1,008,30);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(1,009,37);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(1,010,42);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(1,011,32);

INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(2,001,45);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(2,002,43);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(2,003,27);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(2,004,25);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(2,005,31);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(2,006,27);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(2,007,48);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(2,008,26);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(2,009,34);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(2,010,36);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(2,011,28);

INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(3,001,49);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(3,002,38);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(3,003,32);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(3,004,37);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(3,005,33);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(3,006,36);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(3,007,46);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(3,008,30);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(3,009,37);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(3,010,42);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(3,011,33);

INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(4,001,38);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(4,002,40);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(4,003,36);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(4,004,28);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(4,005,33);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(4,006,35);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(4,007,46);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(4,008,27);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(4,009,35);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(4,010,36);
INSERT INTO Inventory(StoreID, ProductID, ProductQuantity) VALUES(4,011,28);

SELECT * FROM Inventory;