using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for loops are used when you know # of itterations
            // while loop print until the condition is true
            /* int i =0;
             while (i<10) { 

                 Console.WriteLine(i);
                 i++;
             }*/
            int answer=0;
            Console.Write("Enter an number A: ");
            int numA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter an number B: ");
            int numB = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is " + numA + " multiplied by " + numB + ": ");
            //int answer = Convert.ToInt32(Console.ReadLine());

            /* while (answer != numA * numB)
             {
                 if (answer != numA * numB)
                 {
                     Console.Write("Try again: ");
                     answer = Convert.ToInt32(Console.ReadLine());
                 }
             }*/

            //Console.Write("Well Done");

            //Do while happens once, checks condition at the end then loops back if condition is still true.
            //first iteration does not depend on anything whilst 2nd ens... does depend on a condition
            do
            {
                Console.Write("Enter your answer: ");
                answer = Convert.ToInt32(Console.ReadLine());

                if (answer != numA * numB)
                {
                    Console.Write("Try again: ");
                }
            }while (answer != numA * numB);
            Console.Write("Well Done");
            Console.ReadLine(); 


        }
    }
}
