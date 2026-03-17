using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling_Assignment
{
    internal class Ass2
    {
        public int AvailableTickets = 15;
        public int BookedTickets = 0;

        public class TicketsExceed : Exception
        {
            public TicketsExceed(string message) : base(message)
            {

            }
        }

        public void BookTickets(int tickets)
        {
            BookedTickets = tickets;
            if (tickets > AvailableTickets)
            {
                throw new TicketsExceed("Insufficient tickets.Tickets you need exceeded availabale tickets!");
            }
            else
            {
                AvailableTickets -= tickets;
                Console.WriteLine("Tickets Booked Successfully!Enjoy..!");
            }
        }
        static void Main(string[] args)
        {
            Ass2 c1 = new Ass2();
            Console.WriteLine("Do you want to book tickets? (yes/no)");
            string choice = Console.ReadLine();

            try
            {
                if (choice == "yes")
                {
                    Console.WriteLine("Enter no.of tickets you need: ");
                    int Tickets = int.Parse(Console.ReadLine());
                    c1.BookTickets(Tickets);
                }
                else if (choice == "no")
                {
                    Console.WriteLine("Thank you..!");
                }
                else
                {
                    Console.WriteLine("Invalid Input! Please Enter yes or no..");
                }
            }
            catch (TicketsExceed e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
