using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstFizzBuzz
{
    class Program
    {
        /* This program is my simple implementation of the FizzBuzz test.
         * Written by Kenneth R. Perkins
         * July 28, 2017 */
          
        static void Main(string[] args)
        {
            // For Loop intialization
            for (int i = 1; i <= 100; i++)
            {
                // First if checks if divisible by 3 and 5 if yes, prints FizzBuzz
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                // Checks if divisible by 3, if yes, print Fizz
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                // Divisible by 5, print Buzz
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                // If none of above true, print #
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
