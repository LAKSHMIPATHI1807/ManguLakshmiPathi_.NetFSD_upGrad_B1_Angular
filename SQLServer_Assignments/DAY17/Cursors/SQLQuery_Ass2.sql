-- Assignment2

CREATE PROCEDURE sp_CalculateStudentTotalMarks
AS
BEGIN
DECLARE @StudentID INT;
DECLARE @FirstName VARCHAR(20);
DECLARE @TotalMarks VARCHAR(10);
DECLARE TotalMarks CURSOR
FOR
SELECT StudentID,FirstName FROM Students;

OPEN TotalMarks;

FETCH NEXT FROM TotalMarks INTO @StudentID,@FirstName

WHILE @@FETCH_STATUS=0
BEGIN
SELECT @TotalMarks = SUM(MarksObtained) FROM Marks
WHERE StudentID=@StudentID;
PRINT 'Name: '+@FirstName + 'TotalMarks: '+ @TotalMarks

FETCH NEXT FROM TotalMarks INTO @StudentID,@FirstName

END

CLOSE TotalMarks;
DEALLOCATE TotalMarks;
END

EXEC sp_CalculateStudentTotalMarks;