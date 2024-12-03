using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEqualsFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello";
            string compare = "Hello";

            if (message.Equals(compare))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Diff");
            }

            Console.WriteLine("Enter your name: ");
            string name  = Console.ReadLine();
            //if (name != String.Empty)
            if (!name.Equals(""))
            {
                Console.WriteLine("Your name is: " + name);
            }
            else {
                Console.WriteLine("Invalid name input");
            }
            //Comparison of string object to an object
            // .Equals function compares value not mom loc
            char[] chars = new char[] { 'H', 'e', 'l', 'l', 'o' };
            object newCompare = new string(chars);
            if (message.Equals(newCompare))
                Console.WriteLine("same");
            else
            {
                Console.WriteLine("Diff");

            }
            //compares value and memory address location
            if (message==newCompare)
                Console.WriteLine("same");
            else
            {
                Console.WriteLine("Diff");

            }

            Console.ReadLine();
        }
    }
}
