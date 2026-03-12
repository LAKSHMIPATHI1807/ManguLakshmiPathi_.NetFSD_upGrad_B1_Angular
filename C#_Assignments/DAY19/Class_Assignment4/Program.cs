namespace Class_Assignment4
{
    class Appointment
    {
        public int AppointmentID;
        public string PatientName;
        public string DoctorName;
        public DateTime AppointmentDate;

        public Appointment() {
            DoctorName = "General Physician";
            AppointmentDate = DateTime.Now;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Appointment p1 = new Appointment();
            p1.AppointmentID = 1;
            p1.PatientName = "Michael";

            Console.WriteLine($"AppointmentId: {p1.AppointmentID} " +
                $"PatientName: {p1.PatientName} " +
                $"DoctorName: {p1.DoctorName} " +
                $"AppointmentDate: {p1.AppointmentDate}");
        }
    }
}
