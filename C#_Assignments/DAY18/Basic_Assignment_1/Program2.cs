using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_1
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            double kilometers;
            double meters;
            Console.WriteLine("Enter kilometers: ");
            kilometers = Convert.ToDouble(Console.ReadLine());

            meters = kilometers * 1000;

            Console.WriteLine($"Distance in meters: {meters}");
        }
    }
}
