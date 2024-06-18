/**
Name: Udendu Abasili
Class: WMAD Jr B
Purpose: Database Creation Script
Date: 06/11/2024


*/




-- Phase 1: Create all the tables

-- Create Roles table
IF OBJECT_ID('Roles') IS NULL
BEGIN
    CREATE TABLE Roles
    (
        RoleID INT PRIMARY KEY IDENTITY(1,1) ,
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


-- Create Departments table
IF OBJECT_ID('Departments') IS NULL
BEGIN
    CREATE TABLE Departments
    (
        DepartmentID INT PRIMARY KEY IDENTITY(1,1),
        DepartmentName VARCHAR(50) NOT NULL UNIQUE,
        Description TEXT,
        ManagerID INT,
        CONSTRAINT FK_Departments_Employees FOREIGN KEY (ManagerID) REFERENCES Employees(EmployeeID)
    );
END
GO

-- Check if the foreign key constraint exists for Employee table
IF NOT EXISTS (
    SELECT 1
FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
WHERE CONSTRAINT_TYPE = 'FOREIGN KEY'
    AND TABLE_NAME = 'Employees'
    AND CONSTRAINT_NAME = 'FK_Employees_Departments'
) 
BEGIN
    -- Alter table to add foreign key constraint
    ALTER TABLE Employees
    ADD CONSTRAINT FK_Employees_Departments FOREIGN KEY (DepartmentID)
    REFERENCES Departments(DepartmentID);
END

-- Check if the foreign key constraint exists for Employee table
IF NOT EXISTS (
    SELECT 1
FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
WHERE CONSTRAINT_TYPE = 'FOREIGN KEY'
    AND TABLE_NAME = 'Employees'
    AND CONSTRAINT_NAME = 'FK_Employees_Users'
)
BEGIN
    -- Alter table to add foreign key constraint
    ALTER TABLE Employees
    ADD CONSTRAINT FK_Employees_Users FOREIGN KEY (UserID)
    REFERENCES Users(UserID);
END




-- Reset auto-increment for Roles table
DBCC CHECKIDENT('Roles', RESEED, 1);

-- Reset auto-increment for Users table
DBCC CHECKIDENT('Users', RESEED, 1);

-- Reset auto-increment for Employees table
DBCC CHECKIDENT('Employees', RESEED, 1);

-- Reset auto-increment for Departments table
DBCC CHECKIDENT('Departments', RESEED, 1);



-- Phase 2: Insert data into the tables

-- Insert allowed roles if not already present
INSERT INTO Roles
    (RoleName, Description, Permission)
VALUES
    ('Admin', 'Administrator with full access', 'ALL'),
    ('Manager', 'Manager with managerial access', 'VIEW_EMPLOYEES, ADD_EMPLOYEE, EDIT_EMPLOYEE, DELETE_EMPLOYEE'),
    ('Employee', 'Regular Employee', 'VIEW_SELF, EDIT_SELF');


SELECT
    *
FROM Roles;