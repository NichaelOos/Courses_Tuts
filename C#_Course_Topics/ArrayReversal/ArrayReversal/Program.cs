using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReversal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[] { 
            0,1, 2, 3, 4, 5, 6,
            };

            Array.Reverse(numbers);

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
            Console.ReadLine();
        }
    }
}
