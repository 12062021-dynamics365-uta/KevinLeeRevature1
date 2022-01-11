CREATE DATABASE SweetnSalty;

CREATE TABLE Person
(
personID INT PRIMARY KEY,
personFname nvarchar(25) NOT NULL,
personLname nvarchar(25) NOT NULL,
);

CREATE TABLE Flavor
(
flavorID INT PRIMARY KEY,
flavorName nvarchar(25) NOT NULL,
);

CREATE TABLE PersonFlavor
(
personID INT FOREIGN KEY REFERENCES Person(personID) ON DELETE CASCADE,
flavorID INT FOREIGN KEY REFERENCES Flavor(flavorID) ON DELETE CASCADE
);