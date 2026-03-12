using System.Security.Cryptography.X509Certificates;

namespace Class_Assignment6
{
    class Billing
    {
        public string PatientName;
        public int ConsultationFee;
        public int TestCharges;

        public double TotalBill(int ConsultationFee, int TestCharges)
        {
            return ConsultationFee + TestCharges;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Billing p1 = new Billing();
            p1.PatientName = "Michael";

            Console.WriteLine($"PatientName: {p1.PatientName}");
            Console.WriteLine($"Total Bill: {p1.TotalBill(600,450)}");
        }
    }
}
