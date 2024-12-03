using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool success=true;

            while (success)
            {
                Console.Write("Enter a number: ");
                //program is assuming that string input is a perfect input
                string numInput = Console.ReadLine();
                //converts string representation of a number to its 32-bit signed integer equivalent, retrun value indcates success
                //try to comvert numInput and place value inside numOutput
                if (int.TryParse(numInput, out int numOutput))
                {
                   success = false;
                    Console.WriteLine(numOutput);

                }
                else
                {
                    Console.WriteLine("failed to convert");
                }
            }

            //tries, if not succeed return 0
            Console.ReadLine();
        }
    }
}
//Use of try pass in every program is essential, since if you have a failed exception the program will close and all data will be lost
//use try pass to circumvent this.