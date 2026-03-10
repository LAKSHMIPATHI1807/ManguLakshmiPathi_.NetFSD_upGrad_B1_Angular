-- Assignment 1

ALTER PROCEDURE sp_AddStudent
@StudentID INT,
@FirstName VARCHAR(50),
@LastName VARCHAR(50),
@DepartmentID INT,
@Gender VARCHAR(1),
@AdmissionDate DATE
AS
BEGIN
BEGIN TRY
INSERT INTO Students(studentID,FirstName,LastName,DepartmentID,Gender,
AdmissionDate) VALUES 
(@StudentID,@FirstName,@LastName,@DepartmentID,@Gender,@AdmissionDate)
END TRY
BEGIN CATCH
PRINT 'Not inserted'
PRINT ERROR_MESSAGE()
END CATCH
END

EXEC sp_AddStudent 34,'LP','M',2,'M','2026-02-16';

EXEC sp_AddStudent 35,'Lakshmi Pathi','Mangu',12,'M','2026-02-22';

SELECT * FROM Students;