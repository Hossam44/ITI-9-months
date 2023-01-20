
--1.	Display the SalesOrderID, ShipDate of the SalesOrderHeader table 
--		(Sales schema) to show SalesOrders that occurred within 
--		the period ‘7/28/2002’ and ‘7/29/2014’

select S.SalesOrderID,s.ShipDate
from Sales.SalesOrderHeader S
where S.OrderDate >= '7/28/2002' and  S.OrderDate <= '7/29/2014'

--2.	Display only Products(Production schema) with a StandardCost below $110.00 
--		(show ProductID, Name only)

select P.ProductID,P.Name
from Production.Product P
where P.StandardCost < 110.00

--3.	Display ProductID, Name if its weight is unknown

select P.ProductID,P.Name
from Production.Product P
where P.Weight is null 

--4.	 Display all Products with a Silver, Black, or Red Color

select *
from Production.Product P
where P.Color in ('Black','Red','Silver')

--5.	 Display any Product with a Name starting with the letter B

select *
from Production.Product P
where P.Name like 'B%'

--6.	Run the following Query
--		UPDATE Production.ProductDescription
--		SET Description = 'Chromoly steel_High of defects'
--		WHERE ProductDescriptionID = 3

UPDATE Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3

select *
from Production.ProductDescription P
where P.Description like '%_%'

--7.	Calculate sum of TotalDue for each OrderDate in Sales.SalesOrderHeader table 
--		for the period between  '7/1/2001' and '7/31/2014'
select S.OrderDate,sum(S.TotalDue)
from Sales.SalesOrderHeader S
group by S.OrderDate
having S.OrderDate >= '7/1/2001' and  S.OrderDate <= '7/31/2014'
order by OrderDate

--8.	 Display the Employees HireDate (note no repeated values are allowed)

Select Distinct E.HireDate
from HumanResources.Employee E

--9.	 Calculate the average of the unique ListPrices in the Product table

select sum(P.ListPrice)
from (select distinct ListPrice from Production.Product) as P

--10.	Display the Product Name and its ListPrice within 
--		the values of 100 and 120 the list should has the following format 
--		"The [product name] is only! [List price]" (the list will be 
--		sorted according to its ListPrice value)

select 'The '+P.Name+'is only! '+ CONVERT(varchar, P.ListPrice)
from Production.Product P
where P.ListPrice >=100 and P.ListPrice<=120
order by P.ListPrice

--11.	a)	 Transfer the rowguid ,Name, SalesPersonID, Demographics from Sales.
--		Store table  in a newly created table named [store_Archive]
--		Note: Check your database to see the new table and how many rows in it?
--		b)	Try the previous query but without transferring the data? 

Select S.Name, S.SalesPersonID,S.Demographics
into store_Archive
from Sales.Store S

Select S.Name, S.SalesPersonID,S.Demographics
into store_Archive1
from Sales.Store S
where 1=2

select *
from store_Archive1

--12.	Using union statement,retrieve the today’s date in different styles
--		using convert or format funtion.
DECLARE @d DATE = '11/10/2022';
SELECT FORMAT( @d, 'd', 'en-US' ) 'US English'  
union all
SELECT FORMAT( @d, 'd', 'en-gb' ) 'British English'  
union all
SELECT FORMAT( @d, 'd', 'de-de' ) 'German'  
union all
SELECT FORMAT( @d, 'd', 'zh-cn' ) 'Chinese Simplified (PRC)'
union all
SELECT FORMAT( @d, 'D', 'en-US' ) 'US English'  
union all
SELECT FORMAT( @d, 'D', 'en-gb' ) 'British English'  
union all
SELECT FORMAT( @d, 'D', 'de-de' ) 'German'  
union all
SELECT FORMAT( @d, 'D', 'zh-cn' ) 'Chinese Simplified (PRC)'