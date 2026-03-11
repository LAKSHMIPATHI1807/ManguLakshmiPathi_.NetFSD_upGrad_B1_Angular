using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_1
{
    internal class Program7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance travelled: ");
            int distance = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the speed: ");
            int speed = int.Parse(Console.ReadLine());

            int time_taken = distance / speed;
            Console.WriteLine("Distance travelled(km): " + distance);
            Console.WriteLine("Speed(m/hr):"+ speed);
            Console.WriteLine("Time taken for the journey(hrs): " + time_taken);
        }
    }
}
