namespace Basic_Assignment_2
{
    internal class Program
    {
        static void DisplayMessage()
        {
            Console.WriteLine(" Welcome to the world of C# ");
        }
        static void Greet()
        {
            string username = "Lucky";

            Console.WriteLine("Hi! " + username);
            Console.WriteLine("Welcome to the world of C#");
        }
        static void Numbers()
        {
            int num1 = 7;
            int num2 = 18;

            Console.WriteLine("Numbers between " + num1 + " and " + num2 + 
                " are:");

            for (int i = num1 + 1; i < num2; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void OddOrEven()
        {
            int num;
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"The given number {num} is Even!");
            }
            else
            {
                Console.WriteLine($"The given number {num} is Odd!");
            }
        }
        static void OddandEven()
        {
            int n, num;
            int evenCount = 0, oddCount = 0;

            Console.Write("Enter how many numbers you want to input: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter number " + i + ": ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            Console.WriteLine("Total Even Numbers: " + evenCount);
            Console.WriteLine("Total Odd Numbers: " + oddCount);
        }
        static void Temperature()
        {
            double fahrenheit, celsius;

            Console.Write("Enter temperature in Fahrenheit: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());

            celsius = (fahrenheit - 32) * (5 / 9);

            Console.WriteLine($"Temperature in Celsius: {celsius}");
        }
        static void Main(string[] args)
        {
            DisplayMessage();
            Greet();
            Numbers();
            OddOrEven();
            OddandEven();
            Temperature();
        }
        
    }
}
