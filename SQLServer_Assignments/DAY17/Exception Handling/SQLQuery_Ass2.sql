-- Assignment 2

ALTER PROCEDURE sp_InsertMarks
@MarkID INT,
@StudentID INT,
@ExamID INT,
@MarksObtained INT
AS
BEGIN
IF @MarksObtained <0 OR @MarksObtained >100
PRINT 'Invalid Marks'
ELSE
INSERT INTO Marks(MarkID,StudentID,ExamID,MarksObtained) VALUES 
(@MarkID,@StudentID,@ExamID,@MarksObtained)
END

EXEC sp_InsertMarks 31,1807,2,96;

SELECT * FROM Exams;
SELECT * FROM Marks;
SELECT * FROM Students;

EXEC sp_InsertMarks 31,34,2,101;