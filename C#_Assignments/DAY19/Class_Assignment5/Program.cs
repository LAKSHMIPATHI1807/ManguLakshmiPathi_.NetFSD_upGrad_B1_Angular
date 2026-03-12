namespace Class_Assignment5
{
    class MedicalTest
    {
        public int TestId;
        public String TestName;
        public double TestCost;

        public MedicalTest(int testid, string testname, double testcost)
        {
            TestId = testid;
            TestName = testname;
            TestCost = testcost;
        }

        public void TestDetails()
        {
            Console.WriteLine($"TestId: {TestId}");
            Console.WriteLine($"TestName: {TestName}");
            Console.WriteLine($"TestCost: {TestCost}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            MedicalTest t1 = new MedicalTest(1,"BloodTest",1035.60);
            t1.TestDetails();
            Console.WriteLine();
            MedicalTest t2 = new MedicalTest(2,"X-Ray",560);
            t2.TestDetails();

        }
    }
}
