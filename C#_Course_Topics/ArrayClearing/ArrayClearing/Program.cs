using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClearing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arrays are static data and fixed in size
            //no way to add or remove data
            //but it can be cleared.

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6,7 };

            //sets range of elements to default element for Dtype
            //default value for int is 0
            
            //Array.Clear(numbers, 0, numbers.Length);
            Array.Clear(numbers, 4,2);

            /*for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = default;
            }*/

            foreach (int i in numbers) 
            {
                Console.Write($"{i} ");
            }

            Console.ReadLine();
        }
    }
}
