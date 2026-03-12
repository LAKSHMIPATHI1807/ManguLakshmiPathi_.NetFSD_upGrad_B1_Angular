namespace Class_Assignment2
{
    class Doctor
    {
        public int DoctorID;
        public string DoctorName;
        public string Specialization;
        public float ConsultationFee;

        public void DoctorDetails()
        {
            Console.WriteLine($"DoctorID: {DoctorID}, " + 
                $"DoctorName: {DoctorName} " +
                $"Specialization: {Specialization} " +
                $"ConsultationFee: {ConsultationFee} ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Doctor d1 = new Doctor();
            Doctor d2 = new Doctor();

            d1.DoctorID = 1;
            d1.DoctorName = "John";
            d1.Specialization = "General Surgeon";
            d1.ConsultationFee = 600;

            d2.DoctorID = 2;
            d2.DoctorName = "Mike";
            d2.Specialization = "Orthopedics";
            d2.ConsultationFee = 444;

            d1.DoctorDetails();
            Console.WriteLine();
            d2.DoctorDetails();
        }
    }
}
