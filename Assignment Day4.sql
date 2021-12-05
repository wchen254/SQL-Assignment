--1.
--A view is a virtual table whose contents are defined by a query. Like a real table, a view consists of a set of named columns and rows of data.--2.--If you modify a view, it will actually be updating the underlying table. virtual table, it doesn't hold any data. --3.--A stored procedure is a prepared SQL code that you can stored as an object in a SQL Server database, and be reused over and over again.--Increase database security, prevent sql injection. Improve performance. Since the same piece of code is used again and again, it results in higher productivity.--Stored procedures can help reduce network traffic.--4.--View does not accepts parameters, stored procedure does. --View can be used as building block in a larger query, stored precedure can`t. --View can contain only one single SELECT query, stored procedure can contain several statements, loops, IF ELSE, etc.--View can NOT perform modifications to any table, stored procedure can perform modification to one or several tables.--View can be used as the target for Insert, update, delete queries. Stored procedure can not be used as the target for Insert, update, delete queries.--5.--usage: Stored procedure can be used for DML, functions are for calculations.
--how to call: Stored procedure called by its name; functions must be called in SELECT .
--input: Stored procedure may or may not take input, functions must have input.
--output: Stored procedure may or may not have output, functions must return some values.
--Stored procedure can call functions but functions cannot call stored precedure.

--6.
--Stored procedure can return multiple result sets.

--7.
--Stored procedure can not be executed as part of SELECT Statement. Since stored procedures are typically executed with an EXEC statement not SELECT. 
--SP does 'something' and may or may not return anything, may also return multiple data sets. So you can't SELECT from it.

--8.
--Triggers are a special type of stored procedure that get executed (fired) when a specific event happens.
--DML trigger
--DDL trigger
--Logon Trigger: authentication

--9.
--Stored procedure can be invoked explicitly by the user. Trigger execute automatically based on the events.
--Stored procedure can take input as a parameter. Trigger can not take input as parameter.
--Stored procedure can reture value. Trigger can not return value.


--1.
CREATE VIEW view_product_order_Chen AS
SELECT p.ProductID, p.ProductName, SUM(od.Quantity) AS [Total Order Quantity]
FROM Products p LEFT JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductID, p.ProductName;

SELECT * FROM view_product_order_Chen

--2.
CREATE PROC sp_product_order_quantity_Chen 
@pid int,
@total_quan int out 
AS
BEGIN
SELECT @total_quan = SUM(od.Quantity)
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID
WHERE p.ProductID = @pid
GROUP BY p.ProductID
END

BEGIN
DECLARE @out int
exec sp_product_order_quantity_Chen 2, @out out
print @out
END

--3.
CREATE PROC sp_product_order_city_Chen @pname varchar(20)
AS
BEGIN
SELECT c.City, SUM(od.Quantity) AS Total_Quan
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID JOIN Orders o ON od.OrderID = o.OrderID JOIN Customers c ON o.CustomerID = c.CustomerID
WHERE p.ProductName = @pname
GROUP BY c.City
ORDER BY SUM(od.Quantity) DESC
END

exec sp_product_order_city_Chen Chang

--4.
CREATE TABLE city_Chen (
Id INT primary key,
City varchar(20) not null
)

CREATE TABLE people_Chen (
Id INT primary key,
Name varchar(20) not null,
City int foreign key references city_Chen(Id) on delete set NULL
)

INSERT INTO city_Chen
VALUES(1, 'Seattle')

INSERT INTO city_Chen
VALUES(2, 'Creen bay')

INSERT INTO people_Chen
VALUES (1, 'Aaron Rodgers', 2)

INSERT INTO people_Chen
VALUES (2, 'Russell Wilson', 1)

INSERT INTO people_Chen
VALUES (3, 'Jody Nelson', 2)

SELECT * FROM people_Chen
SELECT * FROM city_Chen

DELETE FROM city_Chen
WHERE City = 'Seattle'

SELECT * FROM people_Chen
SELECT * FROM city_Chen

INSERT INTO city_Chen
VALUES(3, 'Madison')

UPDATE people_Chen
SET City = 3
WHERE City IS NULL

CREATE VIEW Packers_Chen 
AS
SELECT * FROM people_Chen
WHERE City = 2

SELECT * FROM Packers_Chen

DROP TABLE people_Chen
DROP TABLE city_Chen
DROP VIEW Packers_Chen

--5.
CREATE PROC sp_birthday_employees_Chen
AS
BEGIN
SELECT * INTO birthday_employees_Chen
FROM Employees
WHERE month(BirthDate) = 02
END

exec sp_birthday_employees_Chen

SELECT * FROM birthday_employees_Chen

SELECT * FROM Employees
WHERE month(BirthDate) = 02;

DROP TABLE birthday_employees_Chen;

--6.
--Using UNION, if you get UNION records greater than any of two tables, they don't have same data.