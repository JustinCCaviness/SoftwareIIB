CREATE DATABASE SchedulingSoftware;
GO

USE SchedulingSoftware;
GO

CREATE TABLE country (
    countryId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    country NVARCHAR(50) NOT NULL,
    createDate DATETIME NOT NULL,
    createdBy NVARCHAR(40) NOT NULL,
    lastUpdate DATETIME NOT NULL DEFAULT GETDATE(),
    lastUpdateBy NVARCHAR(40) NOT NULL
);
GO

CREATE TABLE city (
    cityId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    city NVARCHAR(50) NOT NULL,
    countryId INT NOT NULL,
    createDate DATETIME NOT NULL,
    createdBy NVARCHAR(40) NOT NULL,
    lastUpdate DATETIME NOT NULL DEFAULT GETDATE(),
    lastUpdateBy NVARCHAR(40) NOT NULL,
    FOREIGN KEY (countryId) REFERENCES country(countryId)
);
GO

CREATE TABLE address (
    addressId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    address NVARCHAR(50) NOT NULL,
    address2 NVARCHAR(50) NOT NULL,
    cityId INT NOT NULL,
    postalCode NVARCHAR(10) NOT NULL,
    phone NVARCHAR(20) NOT NULL,
    createDate DATETIME NOT NULL,
    createdBy NVARCHAR(40) NOT NULL,
    lastUpdate DATETIME NOT NULL DEFAULT GETDATE(),
    lastUpdateBy NVARCHAR(40) NOT NULL,
    FOREIGN KEY (cityId) REFERENCES city(cityId)
);
GO

CREATE TABLE [user] (
    userId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    userName NVARCHAR(50) NOT NULL,
    password NVARCHAR(50) NOT NULL,
    active BIT NOT NULL,
    createDate DATETIME NOT NULL,
    createdBy NVARCHAR(40) NOT NULL,
    lastUpdate DATETIME NOT NULL DEFAULT GETDATE(),
    lastUpdateBy NVARCHAR(40) NOT NULL
);
GO

CREATE TABLE customer (
    customerId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    customerName NVARCHAR(45) NOT NULL,
    addressId INT NOT NULL,
    active BIT NOT NULL,
    createDate DATETIME NOT NULL,
    createdBy NVARCHAR(40) NOT NULL,
    lastUpdate DATETIME NOT NULL DEFAULT GETDATE(),
    lastUpdateBy NVARCHAR(40) NOT NULL,
    FOREIGN KEY (addressId) REFERENCES address(addressId)
);
GO

CREATE TABLE appointment (
    appointmentId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    customerId INT NOT NULL,
    userId INT NOT NULL,
    title NVARCHAR(255) NOT NULL,
    description NVARCHAR(MAX) NOT NULL,
    location NVARCHAR(MAX) NOT NULL,
    contact NVARCHAR(MAX) NOT NULL,
    type NVARCHAR(MAX) NOT NULL,
    url NVARCHAR(255),
    start DATETIME NOT NULL,
    end DATETIME NOT NULL,
    createDate DATETIME NOT NULL,
    createdBy NVARCHAR(40) NOT NULL,
    lastUpdate DATETIME NOT NULL DEFAULT GETDATE(),
    lastUpdateBy NVARCHAR(40) NOT NULL,
    FOREIGN KEY (customerId) REFERENCES customer(customerId),
    FOREIGN KEY (userId) REFERENCES [user](userId)
);
GO
