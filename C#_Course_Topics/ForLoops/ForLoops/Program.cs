using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++) {
            Console.WriteLine("hi");
            }

            //prints all even numbers
            //print all uneven numbers by starting at 1
            for (int i = 0; i<=10 ; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.Write("What would you like to loop as a message: ");
            string message = Console.ReadLine();
            Console.Write("How many loops: ");
            int loopcount = Convert.ToInt32(Console.ReadLine());
            if (loopcount <= 0)
            {
                Console.WriteLine("Sorry, please enter a value above 0");
            }
            else {
                for (int i = 0; i < loopcount; i++)
                {
                    Console.WriteLine(message);

                }
            }

            
            Console.ReadLine();
        }
    }
}
