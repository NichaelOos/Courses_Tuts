using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfIntArray
{
    internal class Program
    {
        /*
         * Create and initialize int arrau of numbers
         * Create function SumOfNumbers with int return type
         * int array param
         * function should return total of all numbers
         * extra: check array lenth
            * return -1 if array empty
            * check return in main and output message
            * do we nedd to return -1, how else can we make this?
         */
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4};
            int result = SumOfNumber(arr);

            //Works only if result value is positive, if they were negative it would seem empty
            if (result > -1)
            {
                Console.WriteLine($"The sum of the array is: {result}");
            }
            else 
            {
                Console.WriteLine("Can not add up an empty array");
            }

            //Solution 2, no need to create outside variable, calls function which returns a bool

            if (SumOfNumber(arr, out int sum))

            {
                Console.WriteLine($"The total is: {sum}");
            }
            else
            {
                Console.WriteLine("Can not add up an empty array");
            }
            Console.ReadLine();
        }

        static int SumOfNumber(int[] param)
        {
            if (param.Length ==0) 
            { 
                return -1;
            }
            int sum = 0;
            foreach (int i in param) 
            {
                sum += i;
            }

            return sum;
        }

        static bool SumOfNumber(int[] param, out int sum)
        {
            sum = 0;
            if (param.Length == 0)
            {
                return false;
            }
            
            foreach (int i in param)
            {
                sum += i;
            }

            return true;
        }
    }
}
