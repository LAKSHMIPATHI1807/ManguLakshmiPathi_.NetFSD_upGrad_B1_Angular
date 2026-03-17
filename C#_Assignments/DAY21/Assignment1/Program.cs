namespace Assignment1
{
    internal class Program
    {
        class Staff
        {
            public int StaffId;
            public string Name;
            public double BaseSalary;

            public virtual double CalculateSalary()
            {
                return (BaseSalary);
            }
        }
        class Doctor : Staff
        {
            public double ConsultationFee { get; set; }
            public override double CalculateSalary()
            {
                return (BaseSalary + ConsultationFee);
            }
        }
        class Nurse : Staff
        {
            public double NightShiftAllowance;

            public override double CalculateSalary()
            {
                return (BaseSalary+NightShiftAllowance);
            }
        }
        class LabTechnician : Staff
        {
            public double EquipmentAllowance;

            public override double CalculateSalary()
            {
                return (BaseSalary + EquipmentAllowance);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Staff staff1 = new Doctor()
            {
                StaffId = 1,
                Name = "Dr. Smith",
                BaseSalary = 50000,
                ConsultationFee = 20000
            };

            Staff staff2 = new Nurse()
            {
                StaffId = 2,
                Name = "Anita",
                BaseSalary = 30000,
                NightShiftAllowance = 5000
            };

            Staff staff3 = new LabTechnician()
            {
                StaffId = 3,
                Name = "Rahul",
                BaseSalary = 25000,
                EquipmentAllowance = 3000
            };

            Console.WriteLine("Staff Salary Details");
            Console.WriteLine("----------------------");

            Console.WriteLine($"{staff1.Name} Salary: {staff1.CalculateSalary()}");
            Console.WriteLine($"{staff2.Name} Salary: {staff2.CalculateSalary()}");
            Console.WriteLine($"{staff3.Name} Salary: {staff3.CalculateSalary()}");

        }
    }
}
