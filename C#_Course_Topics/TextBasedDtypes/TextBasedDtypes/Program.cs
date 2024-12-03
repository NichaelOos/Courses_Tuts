using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedDtypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Kyle"; // string uses speech marks
            //Can't store an empty character char letter= '';
            char letter = 'A'; // char uses apostrophe's marks
            //Console.Write is used to write in the same line
            //Spacing between output can be done through, empty writeline
            Console.WriteLine("Your name is ");
            Console.WriteLine(name);
            Console.WriteLine(letter);
            Console.ReadLine();
        }
    }
}
