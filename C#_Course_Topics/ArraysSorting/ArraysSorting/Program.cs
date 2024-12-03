using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
                { 1, 2, 3, 4, 7,9,5, 6};
            //String functions return strings
            //array functions returns void hence augemnts numbers itself
            //do not have to create a new variable to store in
            Array.Sort(numbers);
            foreach (int number in numbers) 
            {
                Console.WriteLine($"{number} ");
            }
            Console.ReadLine();
        }
    }
}
