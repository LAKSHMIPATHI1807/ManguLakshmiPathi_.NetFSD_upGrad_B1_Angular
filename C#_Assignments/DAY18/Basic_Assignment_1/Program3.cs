using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_1
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            int num1 = 7, num2 = 18, num3 = 24, num4 = 15, num5 = 9;
            double sum, average;
            sum = num1 + num2 + num3 + num4 + num5;
            average = sum / 5;

            Console.WriteLine($"Sum of the numbers {num1}, {num2}, {num3}," +
                $" {num4}, {num5} is {sum}");
            Console.WriteLine($"Average of the numbers {num1}, {num2}, {num3}," +
                $" {num4}, {num5} is {average}");
        }
    }
}
