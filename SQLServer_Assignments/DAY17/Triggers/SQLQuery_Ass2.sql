-- Assignment2

CREATE TRIGGER trg_PreventStudentDelete
ON Students
AFTER DELETE
AS
BEGIN
IF EXISTS (
SELECT 1 FROM Enrollments E JOIN deleted D ON E.StudentID = D.StudentID
)
BEGIN
RAISERROR('Student has course enrollments and cannot be deleted!',16,1)
ROLLBACK TRANSACTION
END
ELSE
BEGIN
DELETE FROM Students WHERE StudentID IN (SELECT StudentID FROM deleted);
END
END

SELECT * FROM Students;
SELECT * FROM Enrollments;

DELETE FROM Students WHERE StudentID = 17;
DELETE FROM Students WHERE StudentID = 1;