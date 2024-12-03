using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateAndPrintArray();
            Console.ReadLine();
        }

        static void CreateAndPrintArray()
        {
            int[] numbers = new int[3] { 1, 2, 3 };
            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
 