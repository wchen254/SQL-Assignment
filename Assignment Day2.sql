--1.
--Result set is a set of data, could be empty or not, returned by a select statement.

--2.
--Union selects only distinct values, Union All allow duplicate values.

--3.
--INTERSECT, MINUS, EXCEPT.

--4.
--UNION: combine the result-set of two or more SELECT statements.
--JOIN: combine rows from two or more tables, based on a related columns.

--5.
--INNER JOIN: selects records that have matching values in both tables.
--FULL JOIN: return all the rows of both tables, even if there is no match.

--6.
--LEFT JOIN: one of the OUTER JOIN, returns all records from the left table, and the matching records from the right table.
--OUTER JOION: There are another two kinds of outer joins, right join and full join.

--7.
--A cross join returns the Cartesian product of the sets of records from the two joined tables.

--8.
--Having applies only to groups as a whole, and only filters on aggregated functions; WHERE applies to individual rows.
--WHERE goes before aggregations, but HAVING filters after the aggregations.
--WHERE can be used with SELECT, UPDATE, INSERT and Delete; Having can be used only with SELECT.

--9.
--YES, there can be multiple group by.

--1.
SELECT COUNT(ProductID) AS NumOfProduct
FROM Production.Product;

--2.
SELECT COUNT(ProductID) AS NumOfProduct
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL;

--3.
SELECT ProductSubcategoryID, COUNT(ProductID) AS CountedProducts
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL
GROUP BY ProductSubcategoryID;

--4.
SELECT COUNT(ProductID) AS [Number Of None Subcategory]
FROM Production.Product
WHERE ProductSubcategoryID IS NULL;

--5.
--SELECT * FROM Production.ProductInventory

SELECT ProductID, Sum(Quantity) AS SumOfProduct
FROM Production.ProductInventory
GROUP BY ProductID;

--6.
SELECT ProductID, Sum(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID
HAVING SUM(Quantity) < 100;

--7.
SELECT Shelf, ProductID, Sum(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID, Shelf
HAVING SUM(Quantity) < 100;

--8.
SELECT ProductID, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WHERE LocationID = 10
GROUP BY ProductID;

--9.
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
GROUP BY ProductID, Shelf
ORDER BY ProductID;

--10.
SELECT ProductID, Shelf, AVG(Quantity) AS TheAvg
FROM Production.ProductInventory
WhERE Shelf != 'N/A'
GROUP BY ProductID, Shelf;

--11.
--SELECT * FROM Production.Product

SELECT Color, Class, COUNT(ProductID) AS TheCount, AVG(ListPrice) AS AvgPrice
FROM Production.Product
WHERE Color IS NOT NULL AND Class IS NOT NULL
GROUP BY Color, Class

--12.
SELECT pc.Name AS Country, ps.Name AS Province
FROM Person.CountryRegion pc
INNER JOIN Person.StateProvince ps ON pc.CountryRegionCode = ps.CountryRegionCode;

--SELECT pc.Name AS Country, ps.Name AS Province
--FROM Person.CountryRegion pc, Person.StateProvince ps
--WHERE pc.CountryRegionCode = ps.CountryRegionCode;

--13.
SELECT pc.Name AS Country, ps.Name AS Province
FROM Person.CountryRegion pc
INNER JOIN Person.StateProvince ps ON pc.CountryRegionCode = ps.CountryRegionCode
WHERE pc.Name NOT IN ('Germany','Canada');

--14.
SELECT p.ProductID, p.ProductName, o.OrderID, o.OrderDate
FROM Products p
JOIN [Order Details] od ON p.ProductID = od.ProductID JOIN Orders o ON od.OrderID = o.OrderID
WHERE DATEDIFF(year, o.OrderDate, GETDATE())< 25;

--15.
SELECT TOP 5 o.ShipPostalCode, SUM(od.Quantity) AS [products sold]
FROM Orders o
JOIN [Order Details] od ON o.OrderID = od.OrderID
WHERE o.ShipPostalCode IS NOT NULL
GROUP BY o.ShipPostalCode
ORDER BY 2 DESC;

--16.
SELECT TOP 5 o.ShipPostalCode, SUM(od.Quantity) AS [products sold]
FROM Orders o
JOIN [Order Details] od ON o.OrderID = od.OrderID
WHERE o.ShipPostalCode IS NOT NULL AND DATEDIFF(year, o.OrderDate, GETDATE())< 25
GROUP BY o.ShipPostalCode
ORDER BY 2 DESC;

--17.
SELECT ShipCity, COUNT(CustomerID) AS NumCustomer
FROM Orders
GROUP BY ShipCity;

--18.
SELECT ShipCity, COUNT(CustomerID) AS NumCustomer
FROM Orders
GROUP BY ShipCity
HAVING COUNT(CustomerID) > 2;

--19.
SELECT * FROM Orders

SELECT c.ContactName, o.OrderDate
FROM Orders o
JOIN Customers c ON o.CustomerID = c.CustomerID
WHERE o.OrderDate > '1998-01-01';

--20.
SELECT c.ContactName, MAX(o.OrderDate) AS [most recent order]
FROM Customers c
LEFT JOIN Orders o ON o.CustomerID = c.CustomerID
GROUP BY c.ContactName;

--21.
SELECT c.ContactName, SUM(od.Quantity) AS [Total Orders]
FROM Customers c
LEFT JOIN Orders o ON o.CustomerID = c.CustomerID LEFT JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.ContactName
ORDER BY 2;

--22.
SELECT c.CustomerID, SUM(od.Quantity) AS [Total Orders]
FROM Customers c
LEFT JOIN Orders o ON o.CustomerID = c.CustomerID LEFT JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CustomerID
HAVING SUM(od.Quantity) > 100
ORDER BY 2;

--23.
--SELECT su.CompanyName AS [Supplier Company Name], sh.CompanyName AS [Shipping Company Name]
--FROM Suppliers su
--JOIN Products p ON su.SupplierID = p.SupplierID JOIN [Order Details] od ON p.ProductID = od.ProductID JOIN Orders o ON od.OrderID = o.OrderID JOIN Shippers sh ON o.ShipVia = sh.ShipperID

SELECT DISTINCT sup.CompanyName, ship.CompanyName FROM 
Orders o
LEFT JOIN
[Order Details] od
ON o.OrderID = od.OrderID
INNER JOIN 
Products p
ON od.ProductID = p.ProductID
RIGHT JOIN
Suppliers sup
ON p.SupplierID = sup.SupplierID
INNER JOIN
Shippers ship
ON o.ShipVia = ship.ShipperID;

--24.
SELECT o.OrderDate, p.ProductName
FROM Orders o LEFT JOIN [Order Details] od ON o.OrderID = od.OrderID JOIN Products p ON od.ProductID = p.ProductID
GROUP BY o.OrderDate, p.ProductName
ORDER BY o.OrderDate, p.ProductName;

--25.
SELECT e1.FirstName + ' ' + e1.LastName + ', ' + e2.FirstName + ' ' + e2.LastName AS PairOfEmployees, e1.Title
FROM Employees e1, Employees e2
WHERE e1.Title = e2.Title AND e1.EmployeeID != e2.EmployeeID
ORDER BY Title;

--26.
SELECT e1.EmployeeID, e1.LastName, e1.FirstName, COUNT(e2.EmployeeID) AS [Manage Num Of People]
FROM Employees e1, Employees e2
WHERE e1.EmployeeID = e2.ReportsTo
GROUP BY e1.EmployeeID, e1.LastName, e1.FirstName
HAVING COUNT(e2.EmployeeID) > 2;

--27.
SELECT City, CompanyName, ContactName, Type = 'Customer' 
FROM Customers
UNION
SELECT City, CompanyName, ContactName, Type = 'Supplier'
FROM Suppliers