using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        /*
         * Create a for loop that iterates from 1 to X (15).
         * - If a number is divisible by both 3 and 5, print "FizzBuzz".
         * - If a number is divisible by 3, print "Fizz".
         * - If a number is divisible by 5, print "Buzz".
         * - Otherwise, print the number itself.
         */
        static void Main(string[] args)
        {
            for (int i = 1; i <= 15; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else 
                {
                    Console.WriteLine(i);
                }
            }
            bool threeDiv = false;
            bool fiveDiv = false;


            for (int i = 1; i <= 15; i++)
            {
                threeDiv = i % 3 == 0;
                fiveDiv = i % 5 == 0;
                if (threeDiv && fiveDiv)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (threeDiv)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fiveDiv)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }



            // FizzBuzz logic using a single loop
            for (int i = 1; i <= 15; i++)
            {
                 threeDiv = i % 3 == 0; // Check if divisible by 3
                 fiveDiv = i % 5 == 0;  // Check if divisible by 5

                if (threeDiv && fiveDiv)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (threeDiv)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fiveDiv)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
