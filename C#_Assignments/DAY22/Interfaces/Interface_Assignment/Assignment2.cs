using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Assignment
{
    internal class Assignment2
    {
        public abstract class Sales
        {
            public abstract int MonthlySales(int dailySales);

            public int DailySales()
            {
                return 400;
            }
        }

        public interface ISales
        {
            public int YearlySales(int monthlySales);
        }

        public class SalesCalculation : Sales, ISales
        {
            public override int MonthlySales(int dailySales)
            {
                return 30*dailySales;
            }

            public int YearlySales(int MonthlySales)
            {
                return 12*MonthlySales;
            }

        }
        static void Main(string[] args)
        {
            SalesCalculation obj = new SalesCalculation();

            Console.WriteLine($"Daily Sales: {obj.DailySales()}");
            Console.WriteLine($"Monthly Sales: {obj.MonthlySales(obj.DailySales())}");
            Console.WriteLine($"Yearly Sales: {obj.YearlySales(obj.MonthlySales(obj.DailySales()))}");
        }
    }
}
