-- Assignment 3

CREATE TABLE MarksAudit (
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT,
    ExamID INT,
    OldMarks INT,
    NewMarks INT,
    UpdatedDate DATETIME,
    FOREIGN KEY (AuditID) REFERENCES StudentAudit2(AuditID),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (ExamID) REFERENCES Exams(ExamID),
    FOREIGN KEY (OldMarks) REFERENCES Marks(StudentID)
);