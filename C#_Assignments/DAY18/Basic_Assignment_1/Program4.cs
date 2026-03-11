using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_1
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num%2==0)
            {
                Console.WriteLine($"The given number {num} is Even!");
            }
            else
            {
                Console.WriteLine($"The given number {num} is Odd!");
            }
        }
    }
}
