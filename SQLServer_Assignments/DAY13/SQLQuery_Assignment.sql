-- create database and tables
CREATE DATABASE ASSIGNMENTDB;
USE ASSIGNMENTDB;
CREATE TABLE Worker (
	WORKER_ID INT PRIMARY KEY IDENTITY(1,1),
	FIRST_NAME VARCHAR(25),
	LAST_NAME VARCHAR(25),
	SALARY INT,
	JOINING_DATE DATETIME,
	DEPARTMENT CHAR(25)
);
CREATE TABLE Bonus (
	WORKER_REF_ID INT,
	BONUS_AMOUNT INT,
	BONUS_DATE DATETIME,
	FOREIGN KEY (WORKER_REF_ID)
	REFERENCES Worker(WORKER_ID)
	 ON DELETE CASCADE
);
CREATE TABLE Title (
	WORKER_REF_ID INT,
	WORKER_TITLE CHAR(25),
	AFFECTED_FROM DATETIME,
	FOREIGN KEY (WORKER_REF_ID)
	REFERENCES Worker(WORKER_ID)
	 ON DELETE CASCADE
);

-- insert values into tables
INSERT INTO Worker (FIRST_NAME, LAST_NAME, SALARY, JOINING_DATE, DEPARTMENT) VALUES
('Monika', 'Arora', 100000, '2014-02-20', 'HR'),
('Niharika', 'Verma', 80000, '2014-06-11', 'Admin'),
('Vishal', 'Singhal', 300000, '2014-02-20', 'HR'),
('Amitabh', 'Singh', 500000, '2014-02-20', 'Admin'),
('Vivek', 'Bhati', 500000, '2014-06-11', 'Admin'),
('Vipul', 'Diwan', 200000, '2014-06-11', 'Account'),
('Satish', 'Kumar', 75000, '2014-01-20', 'Account'),
('Geetika', 'Chauhan', 90000, '2014-04-11', 'Admin');

INSERT INTO Bonus (WORKER_REF_ID, BONUS_AMOUNT, BONUS_DATE) VALUES
(1, 10000, '2016-12-20'),
(2, 5000, '2016-12-20'),
(3, 20000, '2015-12-20'),
(4, 30000, '2017-12-20'),
(5, 25000, '2016-12-20'),
(6, 15000, '2016-12-20'),
(7, 5000, '2017-12-20'),
(8, 8000, '2016-12-20');

INSERT INTO Title (WORKER_REF_ID, WORKER_TITLE, AFFECTED_FROM) VALUES
(1, 'HR Executive', '2014-02-20'),
(2, 'Admin Executive', '2014-06-11'),
(3, 'HR Manager', '2014-02-20'),
(4, 'Admin Manager', '2014-02-20'),
(5, 'Admin Manager', '2014-06-11'),
(6, 'Account Manager', '2014-06-11'),
(7, 'Account Executive', '2014-01-20'),
(8, 'Admin Executive', '2014-04-11');

SELECT * FROM Worker;
SELECT * FROM Bonus;
SELECT * FROM Title;

-- 1. Write an SQL query to fetch “FIRST_NAME” from Worker table using the 
--alias name as <WORKER_NAME>
SELECT FIRST_NAME AS WORKER_NAME FROM Worker;

--2. Write an SQL query to fetch “FIRST_NAME” from Worker table in upper case.
SELECT UPPER(FIRST_NAME) FROM Worker;

--Write an SQL query to fetch unique values of DEPARTMENT from Worker table
SELECT DISTINCT DEPARTMENT FROM Worker;

--4. Write an SQL query to print the first three characters of FIRST_NAME 
--from Worker table. 
SELECT LEFT(FIRST_NAME, 3) FROM Worker;

--5. Write an SQL query to find the position of the alphabet (‘a’) in the 
--first name column ‘Amitabh’ from Worker table.
SELECT CHARINDEX('a', FIRST_NAME) FROM Worker WHERE FIRST_NAME = 'Amitabh';

--8. Write an SQL query that fetches the unique values of DEPARTMENT from 
--Worker table and prints its length. 
SELECT DISTINCT DEPARTMENT, LEN(DEPARTMENT) AS DEPT_LENGTH FROM Worker;

--10. Write an SQL query to print the FIRST_NAME and LAST_NAME from Worker 
--table into a single column COMPLETE_NAME. A space char should separate them.
SELECT CONCAT(FIRST_NAME, ' ', LAST_NAME) AS COMPLETE_NAME FROM Worker;

--11. Write an SQL query to print all Worker details from the Worker table 
--order by FIRST_NAME Ascending. 
SELECT * FROM Worker ORDER BY FIRST_NAME ASC;

--12. Write an SQL query to print all Worker details from the Worker table 
--order by FIRST_NAME Ascending and DEPARTMENT Descending.
SELECT * FROM Worker ORDER BY FIRST_NAME ASC, DEPARTMENT DESC;

--13. Write an SQL query to print details for Workers with the first name as 
--“Vipul” and “Satish” from Worker table.
SELECT * FROM Worker WHERE FIRST_NAME IN ('Vipul', 'Satish');

--14. Write an SQL query to print details of workers excluding first names, 
--“Vipul” and “Satish” from Worker table.
SELECT * FROM Worker WHERE FIRST_NAME NOT IN ('Vipul', 'Satish');

--15. Write an SQL query to print details of Workers with DEPARTMENT name as 
--“Admin”. 
SELECT * FROM Worker WHERE DEPARTMENT = 'Admin';

--16. Write an SQL query to print details of the Workers whose FIRST_NAME 
--contains ‘a’.
SELECT * FROM Worker WHERE FIRST_NAME LIKE '%a%';

--17. Write an SQL query to print details of the Workers whose FIRST_NAME 
--ends with ‘a’. 
SELECT * FROM Worker WHERE FIRST_NAME LIKE '%a';

--18. Write an SQL query to print details of the Workers whose FIRST_NAME 
--ends with ‘h’ and contains six alphabets.
SELECT * FROM Worker WHERE FIRST_NAME LIKE '%h' AND LEN(FIRST_NAME) = 6;

--19. Write an SQL query to print details of the Workers whose SALARY lies 
--between 100000 and 500000.
SELECT * FROM Worker WHERE SALARY BETWEEN 100000 AND 500000;

--20. Write an SQL query to print details of the Workers who have joined in 
--Feb’2014.
SELECT * FROM Worker WHERE MONTH(JOINING_DATE) = 2 AND YEAR(JOINING_DATE) = 2014;

--21. Write an SQL query to fetch worker names with salaries >= 50000 
--and <= 100000.
SELECT * FROM Worker WHERE SALARY>=50000 AND SALARY<=100000;

--22. Write an SQL query to fetch the no. of workers for each department in 
--the descending order.
SELECT DEPARTMENT, COUNT(DEPARTMENT) AS NO_OF_EMPLOYEES FROM Worker 
GROUP BY DEPARTMENT 
ORDER BY COUNT(DEPARTMENT) DESC;

--24.Write an SQL query to show the current date and time.
SELECT GETDATE() AS CUR_DATE_TIME;

--23. Write an SQL query to print details of the Workers who are also Managers
SELECT * FROM Worker WHERE WORKER_ID IN (SELECT WORKER_REF_ID FROM Title 
WHERE WORKER_TITLE LIKE '%Manager');

--25.Write an SQL query to show the top n (say 10) records of a table.
SELECT TOP 7 * FROM Worker;
