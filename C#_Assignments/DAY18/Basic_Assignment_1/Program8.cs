using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_1
{
    internal class Program8
    {
        static void Main(string[] args)
        {
            string str;
            char ch;

            Console.WriteLine("Enter a word: ");
            str = Console.ReadLine();

            ch = str[2];

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'O' || ch == 'I' || ch == 'U')
            {
                Console.WriteLine($"The third character {ch} of given " +
                    $"string {str} is an vowel.");
            }
            else
            {
                Console.WriteLine($"The third character {ch} of given " +
                    $"string {str} is an consonant.");
            }

        }
    }
}
