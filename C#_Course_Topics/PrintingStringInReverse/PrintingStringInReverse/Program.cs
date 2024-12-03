using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PrintingStringInReverse
{
    internal class Program
    {
        /*
         * Ask user input
         * Print in order
         * Print in reverse
         * */
        static void Main(string[] args)
        {
            Console.Write("Who is the best league player, and why?: ");
            string answer = Console.ReadLine();
            int length= answer.Length;

            for (int i = 0; i < answer.Length; i++)
            {
                Console.Write(answer[i]);
                Thread.Sleep(100);
            }

            Console.WriteLine();
            for(int i = length-1; i>=0; i--)
            {
                Console.Write(answer[i]);
                Thread.Sleep(100);
            }

            Console.ReadLine();
        }
    }
}
