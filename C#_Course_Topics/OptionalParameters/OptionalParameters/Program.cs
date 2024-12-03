using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(56);
            printName();
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static void printName(string name = "Nika")
        {
            Console.WriteLine($"My name is {name}");
        }

        static int Add(int a, [Optional] int b ) // can also be default set b = default || int b = 50
        { return a + b; }
    }
}
