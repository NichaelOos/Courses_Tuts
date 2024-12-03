using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is: " + name+" and your age is "+ age);
            //== >= <= != || &&
            /*if (age >= 18 && age <=25)
            {
                //dismisses space when working with int
                Console.WriteLine("You are between 18 and 25");
            }
            else if(age>=226)
            {
                Console.WriteLine("You are 26 or older");
            }*/
            /*if (age < 0 || age > 150)
            {
                Console.WriteLine("Invalid age!");
            }
            else
            {
                if(age >= 18 && age <= 25)
            {
                    //dismisses space when working with int
                    Console.WriteLine("You are between 18 and 25");
                }
            else if (age >= 226)
                {
                    Console.WriteLine("You are 26 or older");
                }
            }*/
            Console.Write("Enter a number: ");
            int numberA = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter a second number: ");
            int numberB = Convert.ToInt32(Console.ReadLine());


            int answer = numberA*numberB;
            Console.Write("Enter the value of " + numberA + " multiplied by " + numberB+" : ");
            int answerInput= Convert.ToInt32(Console.ReadLine());

            if (answer==answerInput)
            {
                Console.WriteLine("You are correct the answer is " +answer);
            }
            else
            {
                Console.WriteLine("You are incorrect");
            }
            //Console.Write("Value of " + numberA + " multiplied by " + numberB + " is: " + answer);

            Console.ReadLine();
        }
    }
}
