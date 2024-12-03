using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfMultiples
{
    internal class Program
    {
        /*
         * Define and intialise two integers (num, length)
         * (7,5) ->[7, 14, 21, 28, 35]
         * Create int array with size length
         * loop through and insert the (loop counter x num) into the array
         * print the final array
         */
        static void Main(string[] args)
        {
            int num = 7;
            int length = 5;
            int[] array = new int[length];
            int counter = 0;

            for (int i = 1; i <= length; i++, counter++) //1-5
            {
                array[counter] = i*num;
                //array[i-1]=i*num;
            }
            foreach (int i in array) 
            {
                Console.Write($"{i} ");
            }
            Console.ReadLine();
        }
    }
}
