namespace Class_Assignment7
{
    class Nurse
    {
        private int NurseId;
        private string NurseName;
        private string Department;

        public int Id
        {
            get {  return NurseId; }
            set { NurseId = value; }
        }
        public string Name
        {
            get { return NurseName; }
            set { NurseName = value; }
        }
        public string DepartMent
        {
            get { return Department; }
            set {  Department = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Nurse n1 = new Nurse();
            n1.Id = 1;
            n1.Name = "Grace";
            n1.DepartMent = "ERF";

            Console.WriteLine($"NurseId: {n1.Id}");
            Console.WriteLine($"NurseName: {n1.Name}");
            Console.WriteLine($"Department: {n1.DepartMent}");
        }
    }
}
