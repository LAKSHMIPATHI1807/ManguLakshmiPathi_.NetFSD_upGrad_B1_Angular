-- Assignment 3
CREATE VIEW vw_ExamResults
AS
SELECT S.StudentID, S.FirstName, S.LastName, C.CourseName, E.ExamType,
M.MarksObtained
FROM Students S JOIN Marks M
ON S.StudentID = M.StudentID JOIN Exams E
ON M.ExamID = E.ExamID JOIN Courses C
ON E.CourseID = C.CourseID;

SELECT studentID, FirstName, LastName FROM vw_ExamResults 
WHERE MarksObtained > 80;

SELECT StudentID,FirstName,ExamType,MAX(MarksObtained) AS TopScorer 
FROM vw_ExamResults
GROUP BY StudentID,FirstName,ExamType;

