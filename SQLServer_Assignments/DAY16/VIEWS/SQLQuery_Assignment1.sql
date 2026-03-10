-- Assignment 1
CREATE VIEW vw_StudentDepartment
AS
SELECT S.StudentID,S.FirstName,S.LastName,D.DepartmentName,S.AdmissionDate
FROM Students S JOIN Departments D
ON S.DepartmentID = D.DepartmentID;

SELECT * FROM vw_StudentDepartment;
SELECT * FROM vw_StudentDepartment WHERE DepartmentName = 'Computer Science';
DROP VIEW vw_StudentDepartment;
