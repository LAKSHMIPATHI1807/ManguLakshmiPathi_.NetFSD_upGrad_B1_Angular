using System.Transactions;

namespace ExceptionHandling_Assignment
{
    internal class Program
    {
        class BankAccount
        {
            public long AccountNumber { get; set; }
            public string Name { get; set; }
            public static double Balance = 500;
            public string TransactionType;
            public double TransactionAmount;

            public void Transaction(string Type, double Amount)
            {
                TransactionType = Type;
                TransactionAmount = Amount;

                if (Type == "credit")
                {
                    Balance += Amount;
                    Console.WriteLine("Amount successfully credited!" +
                        "Updated Balance: " + Balance);
                }
                else if (Type == "debit")
                {
                    if (Balance - Amount < 500)
                    {
                        throw new CheckBalanceException("Minimum Balance is 500!" +
                            "Withdraw is unsuccesful!");
                    }
                    else
                    {
                        Balance -= Amount;
                        Console.WriteLine("Withdraw successful!");
                    }
                }
            }
            public void Display()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"AccountNumber: {AccountNumber}");
                Console.WriteLine($"Balance: {Balance}");
            }
            public class CheckBalanceException : Exception
            {
                public CheckBalanceException(string message) : base(message)
                {

                }
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Hello, World!");
                BankAccount a1 = new BankAccount();
                a1.AccountNumber = 741852963012;
                a1.Name = "JC";
                try
                {
                    a1.Transaction("debit", 250);
                }
                catch (CheckBalanceException ex)
                {
                    Console.WriteLine("Transaction Failed: " + ex.Message);
                }
                a1.Display();

                Console.WriteLine();

                BankAccount a2 = new BankAccount();
                a2.Name = "MLP";
                a2.AccountNumber = 789654231052;
                a2.Transaction("credit", 100000);
                a2.Display();
            }
        }
    }
}
