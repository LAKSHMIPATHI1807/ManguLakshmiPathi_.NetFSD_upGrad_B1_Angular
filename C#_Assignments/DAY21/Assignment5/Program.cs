namespace Assignment5
{
    internal class Program
    {
        class Student
        {
            public int StudentId { get; set; }
            public string Name { get; set; }
            public int Marks { get; set; }

            public virtual string CalculateGrade(int marks)
            {
                Marks = marks;
                if (Marks > 50)
                {
                    return "Pass!";
                }
                else
                {
                    return "Fail";
                }
            }
        }

        class SchoolStudent : Student
        {
            public override string CalculateGrade(int marks)
            {
                Marks = marks;
                if (Marks > 40)
                {
                    return "Pass!";
                }
                else
                {
                    return "Fail";
                }
            }
        }

        class CollegeStudent : Student
        {
            public override string CalculateGrade(int marks)
            {
                Marks = marks;
                if (Marks > 50)
                {
                    return "Pass!";
                }
                else
                {
                    return "Fail";
                }
            }
        }

        class OnlineStudent : Student
        {
            public override string CalculateGrade(int marks)
            {
                Marks = marks;
                if (Marks > 60)
                {
                    return "Pass!";
                }
                else
                {
                    return "Fail";
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Student[] students = new Student[4];
            students[0] = new Student();
            students[0].Name = "John";
            students[0].StudentId = 62;
            students[0].Marks = 45;
            students[1] = new SchoolStudent();
            students[1].Name = "MLP";
            students[1].StudentId = 18;
            students[1].Marks = 85;
            students[2] = new CollegeStudent();
            students[2].Name = "John Wick";
            students[2].StudentId = 87;
            students[2].Marks = 70;
            students[3] = new OnlineStudent();
            students[3].Name = "Lucy";
            students[3].StudentId = 92;
            students[3].Marks = 25;


            foreach (Student student in students)
            {
                Console.WriteLine($"StudentId: {student.StudentId}");
                Console.WriteLine($"StudentName: {student.Name}");
                Console.WriteLine($"StudentMarks: {student.Marks}");
                Console.WriteLine("Grade: "+student.CalculateGrade(student.Marks));
                Console.WriteLine("---------------------------");

            }
        }
    }
}
