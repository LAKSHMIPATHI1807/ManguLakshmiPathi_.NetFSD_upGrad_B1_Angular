using System.Security.Cryptography.X509Certificates;

namespace File_Handling_Assignment
{
    internal class Program
    {
        static string filePath = "employee_log.txt";
        public void AddLogin()
        {
            Console.WriteLine("Enter Employee ID: ");
            string id = Console.ReadLine();

            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            string logintime = DateTime.Now.ToString();
            //Console.WriteLine(logintime);
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"EmployeeId: {id} | Name: {name} | LoginTime: {logintime}");
            }
            Console.WriteLine("Login Recorded successfully...!");
        }
        public void UpdateLogout()
        {
            Console.WriteLine("Enter EmployeeId: ");
            string id = Console.ReadLine();

            List<string> lines = new List<string>();
            bool updated = false;

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(Program.filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        string empId = parts[0].Split(':')[1].Trim();

                        if (empId == id && !line.Contains("LogoutTime"))
                        {
                            line = line + " | LogoutTime: " + DateTime.Now.ToString();
                            updated = true;
                        }
                        lines.Add(line);
                    }
                }
                File.WriteAllLines(filePath, lines);
                if (updated)
                {
                    Console.WriteLine("Logout time updated successfully...!");
                }
                else
                {
                    Console.WriteLine("No active login found for this EmployeeId");
                }
            }
            else
            {
                Console.WriteLine("Path does not exist...!");
            }
        }

        public void ViewLogs()
        {
            if(File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(Program.filePath))
                {
                    Console.WriteLine("-------Employee Logs------");
                    Console.WriteLine("EmployeeId | Name | LoginTime | LogoutTime");

                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine($"{line}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No logs found...!");
            }
        }
            
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program p1 = new Program();
            //p1.AddLogin();

            while (true)
            {
                Console.WriteLine("\n----Employee Log Management----");
                Console.WriteLine("1. Add Login Entry");
                Console.WriteLine("2. Update Logout Time");
                Console.WriteLine("3. View Logs");
                Console.WriteLine("4. Exit");
                Console.Write("Choose option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        try
                        {
                            p1.AddLogin();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        finally
                        {
                            Console.WriteLine("Add Login executed..!");
                        }
                        break;
                    case 2:
                        try
                        {
                            p1.UpdateLogout();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        finally
                        {
                            Console.WriteLine("UpdateLogout executed...!");
                        }
                        break;
                    case 3:
                        try
                        {
                            p1.ViewLogs();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        finally
                        {
                            Console.WriteLine("ViewLogs executed..!");
                        }
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
        
    }
    
}
