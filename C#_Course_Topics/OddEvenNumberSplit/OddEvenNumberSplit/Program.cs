using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenNumberSplit
{
    internal class Program
    {
        /*
         * Create two lists with integer data types, one for even one for odd
         * Loop from 0-20
            *if number is even, add to even list
            *if number is odd add to odd
         *Print even list
         *Print odd list
         */
        static void Main(string[] args)
        {
            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else 
                {
                    odd.Add(i);
                }

            }

            for (int i = 0; i < even.Count; i++)
            {
                Console.Write($"{even[i]} ");

            }
            foreach (var item in even)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine(Environment.NewLine + "Printing odd numbers: ");
            for (int i = 0; i < odd.Count; i++)
            {
                Console.Write($"{odd[i]} ");
            }

            Console.ReadLine();
        }
    }
}
