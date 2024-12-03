using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrinConcat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Nika";
            int age = 26;

            //string test = string.Concat("Your name is ",name,", and your age is ",age);
            Console.WriteLine(string.Concat("Your name is ", name, ", and your age is ", age));
            Console.ReadLine();

        }
    }
}
