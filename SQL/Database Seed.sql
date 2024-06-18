/* 
    Name: Udendu Abasili
    Class: WMAD Jr B
    Purpose: Database Seed Script
    Date: 06/11/2024
*/


--  Users table
INSERT INTO Users
    (Username, Password, EMAIL, Role)
VALUES
    ('admin', 'admin', 'admin@example.com', 1),
    ('manager', 'manager123', 'manager@example.com', 2)


SELECT *
FROM Users;
-- Departments table
INSERT INTO Departments
    (DepartmentName, Description)
VALUES
    ('Communication', 'Communication Department'),
    ('IT', 'Information Technology Department'),
    ('Finance', 'Finance Department');

--  Employees table
INSERT INTO Employees
    (FirstName, LastName, Email, DateOfBirth, DepartmentID, EmploymentDate, UserID, SalaryBeforeTax, TaxAmount, SalaryAfterTax)
VALUES
    ('Jane', 'Smith', 'jane.smith@example.com', '1995-05-15', 2, '2021-03-15', 2, 60000.00, 9000.00, 51000.00),
    ('Michael', 'Johnson', 'michael.johnson@example.com', '1988-09-30', 3, '2019-07-01', 1, 55000.00, 8250.00, 46750.00);

-- Add ManagerID to all departments
UPDATE Departments
SET ManagerID = 2
WHERE DepartmentID = 1;

UPDATE Departments
SET ManagerID = 3
WHERE DepartmentID = 2;

