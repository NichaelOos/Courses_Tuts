using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hi, my name is Kyle!");
            Console.Write("Enter your name: ");

            //Input retruned as a string
            string name = Console.ReadLine();
            //Prefer user typing on the same line
            //Console.WriteLine("Your name is: "+ name);
            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);
            // int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is: "+name+ " and you are "+ age+" years old");
            Console.ReadLine();


        }
    }
}
