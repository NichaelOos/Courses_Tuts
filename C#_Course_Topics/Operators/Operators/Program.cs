using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int age = 23;
            age++; //increments age by 1
            Console.WriteLine(age);
            age--;//decreases age by 1
            Console.WriteLine(age);
            age = age + 1;
            // age+=1
            age +=age;
            Console.WriteLine(age);

            age -= 10;
            Console.WriteLine(age);
            age *= 10;
            Console.WriteLine(age);
            age /= 100;
            Console.WriteLine(age);
            //returns int
            //when doing devision use double  

            string name = "Nika ";
            name += "is programming";

            char ch = 'a';
            //Ads unicode values of the chars
            name += 'b';
            Console.WriteLine(ch);
            Console.WriteLine(name);
            int i =0;
            Console.WriteLine(i++);
            //execute from left to right
            Console.WriteLine(++i);
            Console.WriteLine();

            //Remainders:

            int firstNum = 10;
            int secondNum = 3;
            //modulus % returns remainder
            Console.WriteLine(firstNum%secondNum);
            Console.ReadLine();

        }
    }
}
