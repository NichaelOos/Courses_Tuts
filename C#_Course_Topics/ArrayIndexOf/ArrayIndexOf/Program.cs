using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //find specific position of data
            Console.Write("Enter number to search: ");
            int searchnum = Convert.ToInt32(Console.ReadLine());

            //Searches first occurence of num in Array not found returns -1
            //Can have a slice index Array.IndexOf(numbers, searchnum, 2,4)
            if (Array.IndexOf(numbers, searchnum) > -1)
            {
                Console.WriteLine($"The number {searchnum} was found at position {Array.IndexOf(numbers, searchnum)}");
            }
            else 
            {
                Console.WriteLine($"The number {searchnum} was not found in the array");
            }
            //Console.WriteLine($"The number {searchnum} is located at the {Array.IndexOf(numbers, searchnum)} position");

            //CAVEMAN OOGA BOOGA METHOD------------------------------------------------------------------------------------------------------------------------
            int position = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]==searchnum) 
                {
                    position = i;
                }
            }

            if (position > -1)
            {
                Console.WriteLine($"Number {searchnum} has been found at position {position + 1}");
            }
            else 
            {
                Console.WriteLine($"Number {searchnum} has not been found");
            }

            Console.ReadLine();
            
        }
    }
}
