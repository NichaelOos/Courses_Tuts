using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "Nika";
            int age = 26;

            Console.WriteLine("Your name is "+name+", and your age is "+ age);

            //Composite formatting
            Console.WriteLine("Your name is {0}, and your age is {1}" , name, age);

            Console.ReadLine();
        }
    }
}
