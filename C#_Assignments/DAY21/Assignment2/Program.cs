namespace Assignment2
{
    internal class Program
    {
        class Account
        {
            public int AccountNumber { get; set; }
            public double Balance { get; set; }
            
            public void CalculateInterest()
            {
                Console.WriteLine("Base account interest calculation");
            }
        }
        class SavingsAccount : Account
        {
            public new void CalculateInterest()
            {
                Console.WriteLine("Savings account interest 4%!");
            }
        }
        class CurrentAccount : Account
        {
            public new void CalculateInterest()
            {
                Console.WriteLine("Current account interest 9%!");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Account acc = new SavingsAccount();
            acc.CalculateInterest();

            Account acc2 = new CurrentAccount();
            acc2.CalculateInterest();

            CurrentAccount a1 = new CurrentAccount();
            a1.CalculateInterest();

            SavingsAccount a2 = new SavingsAccount();
            a2.CalculateInterest();
        }
    }
}
