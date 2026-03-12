namespace Class_Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Patient P1 = new Patient();
            P1.PatientId = 101;
            P1.PatientName = "Ravi Kumar";
            P1.Age = 45;
            P1.Disease = "Diabetes";
            P1.PatientDetails();
        }
    }
}
