using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //conditional operator
            //condition? value if true? value if false?
            int age = -10 ;

            //string result = age >= 0 ? "Valid" : "Invalid";
            Console.WriteLine(age >= 0 ? "Valid" : "Invalid");
            Console.ReadLine();
        }
    }
}
