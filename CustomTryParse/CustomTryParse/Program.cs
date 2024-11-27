using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTryParse
{
    internal class Program
    {
        /*
         * Create a int and try covert any string to an int
         * Notice the error, write a try and catch handler around it
         * Catch the error and output the error message
         * Without changing the current code
         * 
         * Why is this a bad situation and how can we know if it's been converted
         * 
         * Create a custom try parse function
         * Find the real function and copy return type/params
         * Read the tooltip it gives you, to give you ideas what to do
         */
        static void Main(string[] args)
        {
            /* bool success = false;
             try
             {
                 Console.Write("Enter an int: ");
                 int num = Convert.ToInt32(Console.ReadLine());
                 success = true;
                 Console.WriteLine(num);
             }
             catch (FormatException)
             {
                 Console.WriteLine("Please enter valid integer");
             }
             catch (OverflowException) 
             {
                 Console.WriteLine("Please enter a number less than 2 billion");
             }
             catch (Exception e)
             {
                 Console.WriteLine(e.Message);
             }
            */
            Console.Write("Enter an int: ");
            if (TryParse(Console.ReadLine(), out int result))
            {
                Console.WriteLine($"Converted Successfully: {result}");
            }
            else 
            {
                Console.WriteLine("Unsuccessfull");
            }
            Console.ReadLine();
        }
        //Try parse function only returns with bool hence messages not required
        static bool TryParse(string input, out int result) 
        {
            result = -1;
            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

            
        }
    }
}
