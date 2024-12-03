using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numa = readInt("Enter a Number");
            Console.WriteLine(numa);

            int angle = readInt("Enter an Angle");
            Console.WriteLine(angle);
            

            int firstNum = readInt("first number");
            int secondNum = readInt("second number");
            Console.WriteLine(Add(firstNum,secondNum));


            Console.WriteLine();
            string name = readName("Enter your name");
            int age = readInt("Enter your age");
            string details = UserDetails(name, age);
            Console.WriteLine(details);





            Console.ReadLine();

        }

        static string UserDetails(string name, int age)
        {
            return $"Hello my name is {name} and my age is {age}";
        }
        static string readName(string message)
        {
            Console.Write($"{message}: ");
            return Console.ReadLine();
        }

        static int readInt(string message)
        {
            Console.Write($"{message}: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int Add(int num, int b)
        {
            //num and b are local variables 
            return b + num;
        }


    }


}
