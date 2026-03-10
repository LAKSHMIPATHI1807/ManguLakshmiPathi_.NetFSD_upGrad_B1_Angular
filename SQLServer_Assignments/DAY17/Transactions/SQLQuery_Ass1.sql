-- Assignment 1

ALTER PROCEDURE sp_EnrollStudentTransaction
@EnrollmentID INT,
@StudentID INT,
@CourseID INT
AS
BEGIN
BEGIN TRANSACTION 
BEGIN TRY
INSERT INTO Enrollments (EnrollmentID,StudentID,CourseID) VALUES
(@EnrollmentID,@StudentID,@CourseID)

COMMIT TRANSACTION
END TRY

BEGIN CATCH
ROLLBACK TRANSACTION
PRINT ERROR_MESSAGE()
END CATCH
END

EXEC sp_EnrollStudentTransaction 32,1807, 2;

SELECT * FROM Enrollments;