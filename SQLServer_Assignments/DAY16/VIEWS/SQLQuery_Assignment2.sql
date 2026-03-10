-- Assignment 2
ALTER VIEW vw_StudentCourses
AS
SELECT S.StudentID,S.FirstName,S.LastName,C.CourseName,E.EnrollmentDate
FROM Students S JOIN Enrollments E
ON S.StudentID = E.StudentID JOIN Courses C
ON E.CourseID = C.CourseID;

SELECT CourseName FROM vw_StudentCourses WHERE StudentID = 5;
SELECT StudentID, COUNT(CourseName) AS CourseCount FROM vw_StudentCourses
GROUP BY StudentID;
SELECT FirstName FROM vw_StudentCourses WHERE EnrollmentDate > '2024-01-01';