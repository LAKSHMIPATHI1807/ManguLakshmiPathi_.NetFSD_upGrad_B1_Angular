namespace Class_Assignment8
{
    class PatientRecord
    {
        public static string HospitalName = "Apollo Hospital";
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        private int Age { get; set; }
        private string Disease { get; set; }

        public PatientRecord(int patientId, string patientName, int AGE, string DISEASE)
        {
            PatientId = patientId;
            PatientName = patientName;
            Age = AGE;
            Disease = DISEASE;
        }
        public void DisplayPatientRecord()
        {
            Console.WriteLine($"Hospital: {PatientRecord.HospitalName}");
            Console.WriteLine($"Patient Id: {PatientId}");
            Console.WriteLine($"Name: {PatientName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Disease: {Disease}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine();

            PatientRecord p1 = new PatientRecord(101,"Ravi",40,"Fever");
            p1.DisplayPatientRecord();
            Console.WriteLine();

            PatientRecord p2 = new PatientRecord(102, "Michael", 50, "Knee Pain");
            p2.DisplayPatientRecord();
            Console.WriteLine();

            PatientRecord p3 = new PatientRecord(103, "Brown", 45, "Headache");
            p3.DisplayPatientRecord();
        }
    }
}
