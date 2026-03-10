CREATE VIEW vw_DepartmentStudentCount
AS
SELECT D.DepartmentName, COUNT(S.StudentID) AS TotalStudents
FROM Students S JOIN Departments D
ON S.DepartmentID = D.DepartmentID
GROUP BY D.DepartmentName;

SELECT DepartmentName, TotalStudents FROM vw_DepartmentStudentCount
WHERE TotalStudents > 10;

SELECT DepartmentName, TotalStudents FROM vw_DepartmentStudentCount
ORDER BY TotalStudents DESC;