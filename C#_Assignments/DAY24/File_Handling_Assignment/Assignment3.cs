using System;
using System.Collections.Generic;
using System.Text;

namespace File_Handling_Assignment
{
    internal class Assignment3
    {
        public void CreateFile()
        {
            Console.WriteLine("Enter file name to create: ");
            string filename = Console.ReadLine() + ".txt";
            using (FileStream fs = new FileStream(filename, FileMode.Create)) { };
            Console.WriteLine("File created successfully...!");
        }
        public void Write2File()
        {
            Console.WriteLine("Enter file path to write: ");
            string filepath = Console.ReadLine();

            using (FileStream fs = new FileStream(filepath, FileMode.Open))
            using (StreamWriter streamWriter = new StreamWriter(fs))
            {
                Console.WriteLine("Enter text (type 'END' to stop):");
                while (true)
                {
                    string line = Console.ReadLine();
                    if (line.ToUpper() == "END")
                    {
                        break;
                    }
                    streamWriter.WriteLine(line);
                }
            }
            Console.WriteLine("Content written successfully!");
        }
        public void Append2File()
        {
            Console.WriteLine("Enter file path to write: ");
            string filepath = Console.ReadLine();

            using (FileStream fs = new FileStream(filepath, FileMode.Append))
            using (StreamWriter streamWriter = new StreamWriter(fs))
            {
                Console.WriteLine("Enter text (type 'END' to stop):");
                while (true)
                {
                    string line = Console.ReadLine();
                    if (line.ToUpper() == "END")
                    {
                        break;
                    }
                    streamWriter.WriteLine(line);
                }
            }
            Console.WriteLine("Content appended successfully!");
        }
        public void ReadFile()
        {

            Console.WriteLine("Enter file path to read: ");
            string filepath = Console.ReadLine();
            using (FileStream fs = new FileStream(filepath, FileMode.Open))
            using (StreamReader sr = new StreamReader(fs))
            {
                Console.WriteLine("\n----File Content----");
                Console.WriteLine(sr.ReadToEnd());
            }
        }
        public void DeleteFile()
        {
            Console.WriteLine("Enter file path to delete: ");
            string filepath = Console.ReadLine();
            File.Delete(filepath);
            Console.WriteLine("File Deleted successfully...!");
        }
        static void Main()
        {
            Assignment3 obj = new Assignment3();

            Console.WriteLine("----Mini Notepad----");
            Console.WriteLine("1. Create New File");
            Console.WriteLine("2. Write To File");
            Console.WriteLine("3. Read File");
            Console.WriteLine("4. Append Text");
            Console.WriteLine("5. Delete File");
            Console.WriteLine("6. Exit");

            Console.WriteLine("Enter the choice(1-6): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    try
                    {
                        obj.CreateFile();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        obj.Write2File();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 3:
                    obj.ReadFile();
                    break;
                case 4:
                    obj.Append2File();
                    break;
                case 5:
                    obj.DeleteFile();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}