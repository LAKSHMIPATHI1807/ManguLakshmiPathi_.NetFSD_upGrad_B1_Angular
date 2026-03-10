-- Assignment 1

ALTER PROCEDURE sp_DisplayStudentCursor
AS
BEGIN
DECLARE @StudentID VARCHAR(10);
DECLARE @FirstName VARCHAR(20);
DECLARE @LastName VARCHAR(20);
DECLARE DisplayStudent CURSOR
FOR
SELECT StudentID,FirstName,LastName FROM Students

OPEN DisplayStudent

FETCH NEXT FROM DisplayStudent INTO @StudentID,@FirstName,@LastName

WHILE @@FETCH_STATUS=0
BEGIN
PRINT 'ID: '+ @StudentID  +
'Name: '+ @FirstName + @LastName

FETCH NEXT FROM DisplayStudent INTO @StudentID,@FirstName,@LastName
END

CLOSE DisplayStudent;
DEALLOCATE DisplayStudent;
END

EXEC sp_DisplayStudentCursor;