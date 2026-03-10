CREATE TABLE StudentAudit2 (
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT,
    ActionType VARCHAR(20),
    ActionDate DATETIME
);
CREATE TRIGGER trg_StudentInsertAudit2
ON Students
AFTER INSERT
AS
BEGIN
    INSERT INTO StudentAudit2(StudentID, ActionType, 
    ActionDate)
    SELECT StudentID, 'INSERT', GETDATE()
    FROM inserted;
END;
INSERT INTO Students VALUES
(32,'John','Doe','2004-08-22','M',3,'2024-06-01');

INSERT INTO Students (StudentID,FirstName,LastName,DateOfBirth,Gender,
DepartmentID,AdmissionDate) VALUES (33,'Lakshmi','Pathi','2004-08-22',
'M',3, '2014-07-18');

SELECT * FROM StudentAudit2;