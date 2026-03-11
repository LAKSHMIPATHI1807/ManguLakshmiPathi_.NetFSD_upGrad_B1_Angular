using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_1
{
    internal class Program5
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Enter 1st number: ");
            Console.WriteLine("Enter 2nd number: ");

            num1 = int.Parse(Console.ReadLine());
            num2= int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Highest number: " + num1);
            }
            else
            {
                Console.WriteLine("Highest number: " + num2);
            }

            //Console.WriteLine($"{num1}, {num2}");
        }
    }
}
