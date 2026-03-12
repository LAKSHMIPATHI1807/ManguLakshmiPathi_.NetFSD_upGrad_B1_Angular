namespace Class_Assignment3
{
    class Hospital
    {
        public static string HospitalName = "HRF";
        public static string HospitalAddress = "SouthLandale, Chicago";

        public string PatientName;

        public void Details()
        {
            Console.WriteLine($"HospitalName: {HospitalName} " +
                $"HospitalAddress: {HospitalAddress} " +
                $"PatientName: {PatientName}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Hospital p1 = new Hospital();
            p1.PatientName = "LAPD";

            Hospital p2= new Hospital();
            p2.PatientName = "CPD";

            Hospital p3 = new Hospital();
            p3.PatientName = "CFD";

            p1.Details();
            p2.Details();
            p3.Details();
        }
    }
}
