namespace Interface_Assignment
{
    internal class Program
    {
        interface IGovtRules
        {
            public double EmployeePF(double basicSalary);
            public string LeaveDetails();
            public double gratuityAmount(float serviceCompleted, double basicSalary);

        }
        class TCS : IGovtRules
        {
            private int empid;
            private string name;
            private string dept;
            private string desg;
            private double basicSalary;

            public TCS(int id,string Name,string Dept,string Desg,double BasicSalary)
            {
                empid = id;
                name = Name;
                dept = Dept;
                desg = Desg;
                basicSalary = BasicSalary;
            }

            public int EmpId { get { return empid; } }
            public string Name { get { return name; } }
            public string Dept { get { return dept; } }
            public string Desg { get { return desg; } }
            public double BasicSalary { get { return basicSalary; } }

            public double EmployeePF(double basicSalary)
            {
                double PF = (0.12 * basicSalary);
                double employerPF = (0.0833 * basicSalary);
                double Pension = (0.0367* basicSalary);
                return PF + employerPF + Pension;
            }

            public string LeaveDetails()
            {
                return "1 day of Casual Leave per month, 12 days of Sick Leave per year, 10 days of Previlage Leave per year!";

            }

            public double gratuityAmount(float serviceCompleted, double basicSalary)
            {
                if (serviceCompleted > 20)
                {
                    return 3*basicSalary;
                } else if (serviceCompleted > 10)
                {
                    return 2*basicSalary;
                } else if (serviceCompleted > 5)
                {
                    return basicSalary;
                }
                else if (serviceCompleted < 5)
                {
                    return 0;
                }
                else
                {
                    return 0;
                }
            }
        }

        class Accenture : IGovtRules
        {
            private int empid;
            private string name;
            private string dept;
            private string desg;
            private double basicSalary;
            public Accenture(int id, string Name, string Dept, string Desg, double BasicSalary)
            {
                empid = id;
                name = Name;
                dept = Dept;
                desg = Desg;
                basicSalary = BasicSalary;
            }

            public int EmpId { get { return empid; } }
            public string Name { get { return name; } }
            public string Dept { get { return dept; } }
            public string Desg { get { return desg; } }
            public double BasicSalary { get { return basicSalary; } }

            public double EmployeePF(double basicSalary)
            {
                double PF = (0.12 * basicSalary);
                double employerPF = (0.12 * basicSalary);
                return PF + employerPF;
            }

            public string LeaveDetails()
            {
                return "2 day of Casual Leave per month, 5 days of Sick Leave per year, 5 days of Previlage Leave per year!";

            }

            public double gratuityAmount(float serviceCompleted, double basicSalary)
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine();

            Console.WriteLine("--------------TCS-------------");
            TCS emp1 = new TCS(1807, "MLP", "IT", "SE", 50000);
            Console.WriteLine($"EmpId: {emp1.EmpId}");
            Console.WriteLine($"EmpName: {emp1.Name}");
            Console.WriteLine($"EmpDept: {emp1.Dept}");
            Console.WriteLine($"EmpDesg: {emp1.Desg}");
            Console.WriteLine($"EmpBasicSal: {emp1.BasicSalary}");
            Console.WriteLine($"EmployeePF: {emp1.EmployeePF(emp1.BasicSalary)}");
            Console.WriteLine($"Leaves: {emp1.LeaveDetails()}");
            Console.WriteLine($"GratuityAmt: {emp1.gratuityAmount(11,emp1.BasicSalary)}");

            Console.WriteLine("---------------Accenture------------");
            Accenture emp = new Accenture(18, "M Lakshmi Pathi", "IT", "AAE", 100000);
            Console.WriteLine($"EmpId: {emp.EmpId}");
            Console.WriteLine($"EmpName: {emp.Name}");
            Console.WriteLine($"EmpDept: {emp.Dept}");
            Console.WriteLine($"EmpDesg: {emp.Desg}");
            Console.WriteLine($"EmpBasicSal: {emp.BasicSalary}");
            Console.WriteLine($"EmployeePF: {emp.EmployeePF(emp.BasicSalary)}");
            Console.WriteLine($"Leaves: {emp.LeaveDetails()}");
            Console.WriteLine($"GratuityAmt: {emp.gratuityAmount(7, emp.BasicSalary)}");
        }
    }
}
