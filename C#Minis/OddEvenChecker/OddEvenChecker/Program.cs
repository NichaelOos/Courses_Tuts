using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 12;
            int num2 = 2;

            int remainder = num % num2;
            Console.WriteLine(remainder);
            //Remainder =0 even
            // reassign the variables
            num =13;
            remainder = num % num2;
            Console.WriteLine(remainder);
            //remainder !=0 uneven
            Console.ReadLine();
        }
    }
}
