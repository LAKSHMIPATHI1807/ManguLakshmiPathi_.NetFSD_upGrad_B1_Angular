using System;
using System.Collections.Generic;
using System.Text;

namespace File_Handling_Assignment
{
    internal class Assignment2
    {
        public void SaveStudentDetails()
        {
            Console.WriteLine("Enter Student Name: ");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter Student Roll Number: ");
            string Rollnum = Console.ReadLine();

            int m1 = ValidateMarks();
            int m2 = ValidateMarks();
            int m3 = ValidateMarks();

            int total = m1 + m2 + m3;
            double average = total / 3;

            string grade = Grade(average);

            string content = $@"Student Name: {Name} " +
                $"Roll Number: {Rollnum} " +
                $"Marks: {m1},{m2},{m3} " +
                $"Total: {total} " +
                $"Average: {average} " +
                $"Grade: {grade}";


            string filename = Rollnum + ".txt";
            File.WriteAllText(filename, content);
            Console.WriteLine("Student report saved successfuly..!");
        }

        public int ValidateMarks()
        {
            Console.WriteLine("Enter marks: ");
            int marks = int.Parse(Console.ReadLine());
            if (marks > 0 && marks < 100)
            {
                return marks;
            }
            else
            {
                Console.WriteLine("Enter valid marks between 0 to 100..!");
                return 0;
            }
        }

        public string Grade(double average)
        {
            if (average > 85)
            {
                return "A";
            } else if (average > 75)
            {
                return "B";
            } else if (average > 65)
            {
                return "C";
            }
            else
            {
                return "Fail";
            }
        }

        public void ViewReport()
        {
            Console.WriteLine("Enter Student roll number: ");
            string roll = Console.ReadLine();

            string filename = roll + ".txt";

            if (File.Exists(filename))
            {
                Console.WriteLine("------Report Card------");
                string content = File.ReadAllText(filename);
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("Report not found...File does not exist..!");
            }
        }
        static void Main()
        {
            Assignment2 obj = new Assignment2();
            while (true)
            {
                Console.WriteLine("----Student Report Card Generator----");
                Console.WriteLine("1. Generate Report Card");
                Console.WriteLine("2. View Report Card");
                Console.WriteLine("3. Exit");
                Console.Write("Choose option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        obj.SaveStudentDetails();
                        break;
                    case 2:
                        obj.ViewReport();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}
