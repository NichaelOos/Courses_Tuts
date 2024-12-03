using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIsNullOrEmptyFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Your name is {name}");

            //To avoid name == nothing
            //if(name!="")              option 1
            //if(name.Equals(""))       option 2


            //If the string is null this omit exceptions unlike option 2
            if (!string.IsNullOrEmpty(name))
                Console.WriteLine("2");

            Console.ReadLine();

        }
    }
}
