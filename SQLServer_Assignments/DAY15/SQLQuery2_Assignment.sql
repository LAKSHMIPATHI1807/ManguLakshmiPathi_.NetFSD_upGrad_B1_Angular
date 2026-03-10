CREATE DATABASE SchoolDB;
USE SchoolDB;

-- Assignment 1
CREATE TABLE Departments(
	DepartmentID INT PRIMARY KEY,
	DepartmentName VARCHAR(50) NOT NULL,
	Location VARCHAR(30)
);

CREATE TABLE Teachers(
	TeacherID INT PRIMARY KEY,
	TeacherName VARCHAR(50) NOT NULL,
	Email VARCHAR(50),
	DepartmentID INT,
	HireDate DATE,
);

CREATE TABLE Students(
	StudentID INT PRIMARY KEY,
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	DateOfBirth DATE,
	Gender CHAR(1),
	DepartmentID INT,
	AdmissionDate DATE
);

CREATE TABLE Courses(
	CourseID INT PRIMARY KEY,
	CourseName VARCHAR(50) NOT NULL,
	Credits INT,
	DepartmentID INT,
	TeacherID INT
);

CREATE TABLE Enrollments(
	EnrollmentID INT PRIMARY KEY,
	StudentID INT,
	CourseID INT,
	EnrollmentDate DATE
);

CREATE TABLE Exams(
	ExamID INT PRIMARY KEY,
	CourseID INT,
	ExamDate DATE,
	ExamType VARCHAR(20)
);

CREATE TABLE Marks(
	MarkID INT PRIMARY KEY,
	StudentID INT,
	ExamID INT,
	MarksObtained INT
);

ALTER TABLE Students ADD CONSTRAINT FK_Students_Departments 
FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID);

ALTER TABLE Teachers ADD CONSTRAINT FK_Teachers_Departments
FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID);

ALTER TABLE Courses ADD CONSTRAINT FK_Courses_Departments
FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID);

ALTER TABLE Courses ADD CONSTRAINT FK_Courses_Teachers
FOREIGN KEY (TeacherID) REFERENCES Teachers(TeacherID);

ALTER TABLE Enrollments ADD CONSTRAINT FK_Enrollments_Students
FOREIGN KEY (StudentID) REFERENCES Students(StudentID);

ALTER TABLE Enrollments ADD CONSTRAINT FK_Enrollments_Courses
FOREIGN KEY (CourseID) REFERENCES Courses(CourseID);

ALTER TABLE Marks ADD CONSTRAINT FK_Marks_Students
FOREIGN KEY (StudentID) REFERENCES Students(StudentID);

ALTER TABLE Marks ADD CONSTRAINT FK_Marks_Exams
FOREIGN KEY (ExamID) REFERENCES Exams(ExamID);

-- Assignment 2
ALTER TABLE Departments ADD CONSTRAINT UQ_DepartmentName
UNIQUE (DepartmentName);

ALTER TABLE Students ADD CONSTRAINT CHK_Students
CHECK (Gender IN ('M', 'F'));

ALTER TABLE Courses ADD CONSTRAINT CHK_Courses_Credits
CHECK (Credits BETWEEN 1 AND 5);

ALTER TABLE Marks ADD CONSTRAINT CHK_Marks
CHECK (MarksObtained BETWEEN 0 AND 100);

ALTER TABLE Teachers ADD CONSTRAINT UQ_Teachers_Email
UNIQUE (Email);

ALTER TABLE Enrollments ADD CONSTRAINT DEF_Enrollments_Date
DEFAULT GETDATE() FOR EnrollmentDate;

EXEC sp_help 'Departments';
EXEC sp_help 'Teachers';
EXEC sp_help 'Students';
EXEC sp_help 'Courses';
EXEC sp_help 'Enrollments';
EXEC sp_help 'Exams';
EXEC sp_help 'Marks';

-- Assignment 3
ALTER TABLE Students ADD PhoneNumber VARCHAR(10);

ALTER TABLE Teachers ADD Salary DECIMAL(10, 2);

ALTER TABLE Teachers ALTER COLUMN Salary FLOAT;

ALTER TABLE Teachers ADD CONSTRAINT CHK_Teachers_Salary
CHECK (Salary > 20000);

ALTER TABLE Students
DROP COLUMN PhoneNumber;

--Assignment 4
INSERT INTO Departments (DepartmentID, DepartmentName, Location) VALUES
(1, 'Computer Science', 'Building A'),
(2, 'Mathematics', 'Building B'),
(3, 'Physics', 'Building C'),
(4, 'Chemistry', 'Building D'),
(5, 'Art', 'Building E');

SELECT * FROM Departments;

INSERT INTO Teachers (TeacherID, TeacherName, Email, DepartmentID, HireDate) 
VALUES
(1, 'Dr. Smith', 'smith@gmail.com', 1, '2010-08-15'),
(2, 'Dr. Johnson', 'john@gmail.com', 1, '2011-09-01'),
(3, 'Dr. Williams', 'williams@gmail.com', 2, '2010-10-20'),
(4, 'Dr. Brown', 'brown@gmail.com', 2, '2012-01-10'),
(5, 'Dr. Jones', 'jones@gmail.com', 3, '2013-03-05'),
(6, 'Dr. Miller', 'miller@gmail.com', 3, '2014-07-22'),
(7, 'Dr. Davis', 'davis@gmail.com', 4, '2010-11-30'),
(8, 'Dr. Garcia', 'garcia@gmail.com', 4, '2012-02-14'),
(9, 'Dr. Martinez', 'martin@gmail.com', 5, '2017-05-18'),
(10, 'Dr. Rodriguez', 'rodriguez@gmail.com', 5, '2018-09-25');

UPDATE Teachers SET Salary = 50000;

SELECT * FROM Teachers;

INSERT INTO Students (StudentID, FirstName, LastName, DateOfBirth, Gender, 
DepartmentID, AdmissionDate) VALUES
(1, 'Alice', 'Smith', '2000-01-15', 'F', 1, '2018-08-20'),
(2, 'Bob', 'Johnson', '1999-05-10', 'M', 1, '2017-09-01'),
(3, 'Charlie', 'Williams', '2001-03-22', 'M', 2, '2019-10-20'),
(4, 'David', 'Brown', '2000-07-30', 'M', 2, '2018-01-10'),
(5, 'Eve', 'Jones', '1998-11-05', 'F', 3, '2017-03-05'),
(6, 'Frank', 'Miller', '2001-02-14', 'M', 3, '2019-07-22'),
(7, 'Grace', 'Davis', '1999-09-18', 'F', 4, '2018-11-30'),
(8, 'Hank', 'Garcia', '2000-12-25', 'M', 4, '2017-02-14'),
(9, 'Ivy', 'Martinez', '2001-06-10', 'F', 5, '2019-05-18'),
(10, 'Jack', 'Rodriguez', '1998-04-05', 'M', 5, '2018-09-25'),
(11, 'Karen', 'Wilson', '2000-08-15', 'F', 1, '2018-08-20'),
(12, 'Leo', 'Anderson', '1999-12-10', 'M', 1, '2017-09-01'),
(13, 'Mia', 'Thomas', '2001-04-22', 'F', 2, '2019-10-20'),
(14, 'Nina', 'Taylor', '2000-08-30', 'F', 2, '2018-01-10'),
(15, 'Oscar', 'Moore', '1998-12-05', 'M', 3, '2017-03-05'),
(16, 'Paul', 'Jackson', '2001-03-14', 'M', 3, '2019-07-22'),
(17, 'Quinn', 'White', '1999-11-18', 'F', 4, '2018-11-30'),
(18, 'Ryan', 'Harris', '2000-01-25', 'M', 4, '2017-02-14'),
(19, 'Sara', 'Martin', '2001-07-10', 'F', 5, '2019-05-18'),
(20, 'Tom', 'Thompson', '1998-03-05', 'M', 5, '2018-09-25');

SELECT * FROM Students;

INSERT INTO Courses (CourseID, CourseName, Credits, DepartmentID, TeacherID) VALUES
(1, 'Database Systems', 3, 1, 1),
(2, 'Operating Systems', 4, 1, 2),
(3, 'Calculus', 3, 2, 3),
(4, 'Linear Algebra', 4, 2, 4),
(5, 'Quantum Mechanics', 3, 3, 5),
(6, 'Thermodynamics', 4, 3, 6),
(7, 'Organic Chemistry', 3, 4, 7),
(8, 'Inorganic Chemistry', 4, 4, 8),
(9, 'Painting', 3, 5, 9),
(10, 'Sculpture', 4, 5, 10);

SELECT * FROM Courses;

INSERT INTO Enrollments (EnrollmentID, StudentID, CourseID, EnrollmentDate) VALUES
(1, 1, 1, '2018-08-20'),
(2, 1, 2, '2018-08-20'),
(3, 2, 1, '2017-09-01'),
(4, 2, 3, '2017-09-01'),
(5, 3, 4, '2019-10-20'),
(6, 3, 5, '2019-10-20'),
(7, 4, 4, '2018-01-10'),
(8, 4, 6, '2018-01-10'),
(9, 5, 5, '2017-03-05'),
(10, 5, 7, '2017-03-05'),
(11, 6, 5, '2019-07-22'),
(12, 6, 8, '2019-07-22'),
(13, 7, 7, '2018-11-30'),
(14, 7, 9, '2018-11-30'),
(15, 8, 7, '2017-02-14'),
(16, 8, 10, '2017-02-14'),
(17, 9, 9, '2019-05-18'),
(18, 9, 10, '2019-05-18'),
(19, 10, 1, '2018-09-25'),
(20, 10, 2, '2018-09-25'),
(21, 11, 1, '2018-08-20'),
(22, 11, 2, '2018-08-20'),
(23, 12, 1, '2017-09-01'),
(24, 12, 3, '2017-09-01'),
(25, 13, 4, '2019-10-20'),
(26, 13, 5, '2019-10-20'),
(27, 14, 4, '2018-01-10'),
(28, 14, 6, '2018-01-10'),
(29, 15, 5, '2017-03-05'),
(30, 15, 7, '2017-03-08');
INSERT INTO Enrollments VALUES (31, 16, 5, GETDATE());

SELECT * FROM Enrollments;

INSERT INTO Exams (ExamID, CourseID, ExamDate, ExamType) VALUES
(1, 1, '2020-05-20', 'Final'),
(2, 2, '2020-05-25', 'Final'),
(3, 3, '2020-05-15', 'Final'),
(4, 4, '2020-05-22', 'Final'),
(5, 5, '2020-05-18', 'Final');

SELECT * FROM Exams;

INSERT INTO Marks (MarkID, StudentID, ExamID, MarksObtained) VALUES	
(1, 1, 1, 85),
(2, 1, 2, 90),
(3, 2, 1, 80),
(4, 2, 3, 75),
(5, 3, 4, 88),
(6, 3, 5, 92),
(7, 4, 1, 78),
(8, 4, 2, 82),
(9, 5, 3, 91),
(10, 5, 4, 89),
(11, 6, 5, 87),
(12, 6, 1, 90),
(13, 7, 2, 85),
(14, 7, 3, 93),
(15, 8, 4, 80),
(16, 8, 5, 88),
(17, 9, 1, 92),
(18, 9, 2,95 ),
(19 ,10 ,1 ,84 ),
(20 ,10 ,2 ,89 ),
(21 ,11 ,1 ,86 ),
(22 ,11 ,2 ,91 ),
(23 ,12 ,1 ,79 ),
(24 ,12 ,3 ,77 ),
(25 ,13 ,4 ,90 ),
(26 ,13 ,5 ,94 ),
(27 ,14 ,4 ,82 ),
(28 ,14 ,3 ,85 ),
(29 ,15 ,5 ,88 ),
(30, 15, 4, 90);

SELECT * FROM Marks;

-- Assignment 5
SELECT * FROM Students;
SELECT * FROM Teachers;
SELECT * FROM Departments;
SELECT * FROM Courses;
SELECT * FROM Enrollments;
SELECT * FROM Exams;
SELECT * FROM Marks;

-- 1
SELECT S.StudentID, S.FirstName, S.LastName 
FROM Students S JOIN Departments D
ON S.DepartmentID = D.DepartmentID
WHERE D.DepartmentName = 'Computer Science';

-- 2
SELECT * FROM Teachers WHERE HireDate > '2010-12-01';

-- 3
SELECT * FROM Students WHERE FirstName LIKE 'A%';

-- 4
SELECT * FROM Courses WHERE Credits > 3;

-- 5
SELECT * FROM Students WHERE DateOfBirth 
BETWEEN ('2005-01-01') AND ('2008-12-31');

-- 6
SELECT S.* FROM Students S JOIN Departments D
ON S.DepartmentID = D.DepartmentID
WHERE D.DepartmentName <> 'Mechanical';

-- 7
SELECT * FROM Teachers WHERE Salary BETWEEN 40000 AND 70000;

-- 8
SELECT C.* FROM Courses C JOIN Teachers T
ON C.TeacherID = T.TeacherID
WHERE T.TeacherID <> 3;

-- Assignment 6

-- 1
SELECT D.DepartmentName, COUNT(S.StudentID) AS StudentCount
FROM Departments D LEFT JOIN Students S
ON D.DepartmentID = S.DepartmentID
GROUP BY D.DepartmentName;

-- 2
SELECT E.ExamID, E.ExamType, AVG(M.MarksObtained) AS AverageMarks
FROM Exams E JOIN Marks M
ON E.ExamID = M.ExamID
GROUP BY E.ExamID, E.ExamType;

-- 3
SELECT C.CourseName, COUNT(E.EnrollmentID) AS EnrollmentCount
FROM Courses C LEFT JOIN Enrollments E
ON C.CourseID = E.CourseID
GROUP BY C.CourseName;

-- 4
SELECT E.ExamID, E.ExamType, MAX(M.MarksObtained) AS HighestMarks
FROM Exams E JOIN Marks M
ON E.ExamID = M.ExamID
GROUP BY E.ExamID, E.ExamType;

-- 5
SELECT C.CourseName, MIN(M.MarksObtained) AS LowestMarks
FROM Courses C JOIN Exams E
ON C.CourseID = E.CourseID JOIN Marks M
ON E.ExamID = M.ExamID
GROUP BY C.CourseName;

-- 6
SELECT D.DepartmentName, COUNT(S.StudentID) AS StudentCount
FROM Departments D JOIN Students S
ON D.DepartmentID = S.DepartmentID
GROUP BY D.DepartmentName
HAVING COUNT(S.StudentID) > 2;

-- Assignment 7

-- 1
SELECT S.FirstName, S.LastName, D.DepartmentName
FROM Students S JOIN Departments D
ON S.DepartmentID = D.DepartmentID;

-- 2
SELECT T.TeacherName, C.CourseName
FROM Teachers T JOIN Courses C
ON T.TeacherID = C.TeacherID;

-- 3
SELECT S.FirstName, S.LastName, E.CourseID, C.CourseName
FROM Students S JOIN Enrollments E
ON S.StudentID = E.StudentID JOIN Courses C
ON E.CourseID = C.CourseID;

-- 4
SELECT S.FirstName, S.LastName, M.MarksObtained
FROM Students S JOIN Marks M
ON S.StudentID = M.StudentID JOIN Exams E
ON M.ExamID = E.ExamID;

-- 5
SELECT T.TeacherName, C.CourseName
FROM Teachers T LEFT JOIN Courses C
ON T.TeacherID = C.TeacherID;

-- 6
SELECT T.TeacherName FROM Teachers T LEFT JOIN Courses C
ON T.TeacherID = C.TeacherID
WHERE C.CourseID IS NULL;

-- Assignment 8

-- 1
-- Find students whose marks are greater than average marks
SELECT S.FirstName, S.LastName, M.MarksObtained
FROM Students S JOIN Marks M
ON S.StudentID = M.StudentID
WHERE M.MarksObtained > (SELECT AVG(MarksObtained) FROM Marks);

SELECT AVG(MarksObtained) FROM Marks;

-- 3
SELECT S.FirstName, COUNT(E.EnrollmentID) AS CourseCount
FROM Students S JOIN Enrollments E
ON S.StudentID = E.StudentID
GROUP BY S.StudentID, S.FirstName
HAVING COUNT(E.EnrollmentID) >= 2 ;

-- 2
SELECT CourseName, Credits
FROM Courses WHERE Credits = (SELECT MAX(Credits) FROM Courses);

-- 4
SELECT T.TeacherName, D.DepartmentName
FROM Teachers T JOIN Departments D
ON T.DepartmentID = D.DepartmentID
WHERE D.DepartmentID = (SELECT DepartmentID FROM Teachers 
WHERE TeacherName = 'Dr. Jones');

-- 5
SELECT S.FirstName, M.MarksObtained
FROM Students S JOIN Marks M
ON S.StudentID = M.StudentID
WHERE M.MarksObtained = (SELECT MAX(MarksObtained) FROM Marks 
WHERE StudentID = 1 AND ExamID = 1);

-- 6
SELECT DepartmentName, StudentCount FROM
(SELECT D.DepartmentName, COUNT(S.StudentID) AS StudentCount
FROM Departments D JOIN Students S
ON D.DepartmentID = S.DepartmentID
GROUP BY D.DepartmentName) AS DeptCounts
WHERE StudentCount = (SELECT MAX(StudentCount) FROM
(SELECT D.DepartmentName, COUNT(S.StudentID) AS StudentCount
FROM Departments D JOIN Students S
ON D.DepartmentID = S.DepartmentID
GROUP BY D.DepartmentName) AS DeptCounts2);
