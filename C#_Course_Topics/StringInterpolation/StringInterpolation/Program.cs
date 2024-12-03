using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Nika";
            int age = 26;

            Console.WriteLine("Your name is "+ name+", and your age is "+ age);
            Console.WriteLine($"Your name is {name}, and your age is {age}");
            Console.ReadLine();
        }
    }
}
