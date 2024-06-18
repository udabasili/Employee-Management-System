/**
Name: Udendu Abasili
Class: WMAD Jr B
Purpose: Project Testing Script
Date: 06/04/2024


*/
USE AP;

IF NOT EXISTS (SELECT *
FROM sys.databases
WHERE name = 'HRManagement')
BEGIN
    CREATE DATABASE HRManagement;
END


-- DROP DATABASE HRManagement;
USE HRManagement;
GO

-- Phase 1: Create all the tables

-- Create Roles table
IF OBJECT_ID('Roles') IS NULL
BEGIN
    CREATE TABLE Roles
    (
        RoleID INT PRIMARY KEY IDENTITY(1,1),
        RoleName VARCHAR(20) NOT NULL UNIQUE,
        Description VARCHAR(255) ,
        Permission VARCHAR(60),
    );
END
GO


-- Create Users table
IF OBJECT_ID('Users') IS NULL
BEGIN
    CREATE TABLE Users
    (
        UserID INT PRIMARY KEY IDENTITY(1,1),
        Username VARCHAR(60) NOT NULL,
        Password VARCHAR(20) NOT NULL,
        EMAIL VARCHAR(30) NOT NULL UNIQUE,
        Role INT,
        CreatedAt DATE DEFAULT GETDATE(),
        FOREIGN KEY(Role) REFERENCES Roles(RoleID)
    );
END
GO

-- Create Employees table
IF OBJECT_ID('Employees') IS NULL
BEGIN
    CREATE TABLE Employees
    (
        EmployeeID INT PRIMARY KEY IDENTITY(1,1),
        FirstName VARCHAR(20) NOT NULL,
        LastName VARCHAR(20) NOT NULL,
        Email VARCHAR(30) NOT NULL UNIQUE,
        DateOfBirth DATE NULL,
        DepartmentID INT,
        EmploymentDate DATE NULL,
        UserID INT,
        SalaryBeforeTax DECIMAL(10, 2) NULL,
        TaxAmount DECIMAL(10, 2) NULL,
        SalaryAfterTax DECIMAL(10, 2) NULL,
        --FOREIGN KEY(DepartmentID) REFERENCES Departments(DepartmentID),
        --FOREIGN KEY(UserID) REFERENCES Users(UserID)
    );
END
GO

--  make salary after tax, salary before tax, tax amount, and employment date nullable
ALTER TABLE Employees
ALTER COLUMN SalaryBeforeTax DECIMAL(10, 2) NULL;
ALTER TABLE Employees
ALTER COLUMN TaxAmount DECIMAL(10, 2) NULL;
ALTER TABLE Employees
ALTER COLUMN SalaryAfterTax DECIMAL(10, 2) NULL;
ALTER TABLE Employees
ALTER COLUMN EmploymentDate DATE NULL;

-- Create Departments table
IF OBJECT_ID('Departments') IS NULL
BEGIN
    CREATE TABLE Departments
    (
        DepartmentID INT PRIMARY KEY IDENTITY(1,1),
        DepartmentName VARCHAR(50) NOT NULL UNIQUE,
        Description TEXT,
        ManagerID INT,
        FOREIGN KEY(ManagerID) REFERENCES Employees(EmployeeID)
    );
END
GO

ALTER TABLE Employees ADD CONSTRAINT FK_Employees_Departments FOREIGN KEY(DepartmentID) REFERENCES Departments(DepartmentID);
ALTER TABLE Employees ADD CONSTRAINT FK_Employees_Users FOREIGN KEY(UserID) REFERENCES Users(UserID);





-- Phase 2: Insert data into the tables

-- Insert data into Roles table

-- Create Roles table if it doesn't exist

-- Insert allowed roles if not already present
INSERT INTO Roles
    (RoleName, Description, Permission)
VALUES
    ('Admin', 'Administrator with full access', 'ALL'),
    ('Manager', 'Manager with managerial access', 'VIEW_EMPLOYEES, ADD_EMPLOYEE, EDIT_EMPLOYEE, DELETE_EMPLOYEE'),
    ('Employee', 'Regular Employee', 'VIEW_SELF, EDIT_SELF');


SELECT RoleID, RoleName
FROM Roles;

SELECT *
FROM Departments

SELECT *
FROM Employees

SELECT
    (SELECT TOP(1)
        DepartmentId as FirstDepartmentId
    FROM Departments
    ORDER BY DepartmentID
        ) as FirstDepartmentId,
    NavInfo.PreviousDepartmentId,
    NavInfo.NextDepartmentId,
    (SELECT TOP(1)
        DepartmentId as LastDepartmentId
    FROM Departments
    ORDER BY DepartmentID Desc
        ) as LastDepartmentId,
    NavInfo.RowNumber
FROM
    (
    SELECT
        DepartmentId,
        DepartmentName,
        LEAD(DepartmentId) OVER(ORDER BY DepartmentID) AS NextDepartmentId,
        LAG(DepartmentId) OVER(ORDER BY DepartmentID) AS PreviousDepartmentId,
        ROW_NUMBER() OVER(ORDER BY DepartmentID) AS 'RowNumber'
    FROM Departments
    ) AS NavInfo
WHERE DepartmentId = 1;

SELECT *
FROM Users;

SELECT
    Employees.EmployeeID,
    Employees.FirstName,
    Employees.LastName,
    Employees.Email,
    Employees.DateOfBirth,
    Departments.DepartmentName,
    Employees.EmploymentDate,
    Employees.SalaryBeforeTax,
    Employees.TaxAmount,
    Employees.SalaryAfterTax,
    -- get manager id
    (SELECT Departments.ManagerID
    FROM Departments
    WHERE Departments.DepartmentID = Employees.DepartmentID) as ManagerID,


    -- get the manager name
    (SELECT CONCAT(Employees.FirstName, ' ', Employees.LastName)
    FROM Employees
    WHERE Employees.EmployeeID = Departments.ManagerID) as ManagerName

FROM Employees
    INNER JOIN Departments
    ON Employees.DepartmentID = Departments.DepartmentID;


SELECT
    (SELECT CONCAT(Employees.FirstName, ' ', Employees.LastName)
    FROM Employees
    WHERE Employees.EmployeeID = Departments.ManagerID) as ManagerName,
    (SELECT Departments.ManagerID
    FROM Departments
    WHERE Departments.DepartmentID = NavInfo.DepartmentID)
as ManagerID,
    NavInfo.DepartmentID,
    (SELECT TOP(1)
        EmployeeId as FirstEmployeeId
    FROM Employees
    ORDER BY EmployeeID
        ) as FirstEmployeeId,
    NavInfo.PreviousEmployeeId,
    NavInfo.NextEmployeeId,
    (SELECT TOP(1)
        EmployeeId as LastEmployeeId
    FROM Employees
    ORDER BY EmployeeID Desc
        ) as LastEmployeeId,
    NavInfo.RowNumber
FROM
    (
    SELECT
        EmployeeId,
        FirstName,
        LastName,
        Email,
        DateOfBirth,
        DepartmentID,
        EmploymentDate,
        LEAD(EmployeeId) OVER(ORDER BY EmployeeID) AS NextEmployeeId,
        LAG(EmployeeId) OVER(ORDER BY EmployeeID) AS PreviousEmployeeId,
        ROW_NUMBER() OVER(ORDER BY EmployeeID) AS 'RowNumber'
    FROM Employees
) AS NavInfo
    INNER JOIN Departments
    ON NavInfo.DepartmentID = Departments.DepartmentID
WHERE NavInfo.EmployeeId = 3
ORDER BY NavInfo.EmployeeID


SELECT *
from Employees
WHERE EmployeeID = 6;
UPDATE Employees
SET FirstName = 'John',
    LastName = 'Doe',
    Email = 'joe@yahoo.com',
    DateOfBirth = '1990-01-01',
    DepartmentID = 1,
    EmploymentDate = '2020-01-01'
WHERE EmployeeID = 6;



SELECT *
FROM Employees
UPDATE Employees
SET DepartmentID = 4
WHERE EmployeeID = 7;
-- get the manager name of the department id 4
SELECT
    (SELECT CONCAT(FirstName, ' ', LastName)
    FROM Employees
    WHERE Employees.EmployeeID = Departments.ManagerID) as ManagerName
FROM Departments
WHERE DepartmentID = 1;

SELECT
    (
    SELECT CONCAT(FirstName, ' ', LastName) as FullName
    FROM Employees
    WHERE Employees.EmployeeID = Departments.ManagerID
    ) as CurrentManager,
    CONCAT(FirstName, ' ', LastName) as FullName
FROM Employees
    INNER JOIN Departments
    ON Employees.DepartmentID = Departments.DepartmentID
WHERE Departments.DepartmentID = 1;

SELECT DepartmentID, DepartmentName
FROM Departments

SELECT
    EmployeeID,
    CONCAT(FirstName, ' ', LastName) as FullName,
    SalaryBeforeTax,
    TaxAmount,
    SalaryAfterTax
FROM Employees


UPDATE Employees
SET FirstName
    = 'John',
    LastName = 'Doe',
    Email = 'j.e@yahoo.com',
    DateOfBirth = '1990-01-01',
    EmploymentDate = '2020-01-01'
WHERE UserID = 1;


UPDATE
Users
SET
    Username = 'admin',
    Password = 'admin123',
    Email = 'admin@yahoo.com'
WHERE UserID= 1;

