-- Assignment3

CREATE PROCEDURE sp_UpdateCourseCredits
AS
BEGIN
DECLARE @CourseID INT;
DECLARE @Credits INT;
DECLARE UpdateCourseCredits CURSOR
FOR
SELECT CourseID,Credits FROM Courses WHERE Credits<3;

OPEN UpdateCourseCredits;

FETCH NEXT FROM UpdateCourseCredits INTO @CourseID,@Credits;

WHILE @@FETCH_STATUS=0
BEGIN
UPDATE Courses SET Credits=Credits+1 WHERE CourseID=@CourseID;

FETCH NEXT FROM UpdateCourseCredits INTO @CourseID,@Credits
END

CLOSE UpdateCourseCredits;
DEALLOCATE UpdateCourseCredits;
END

SELECT * FROM Courses;

EXEC sp_UpdateCourseCredits;

SELECT * FROM Courses;