using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if array can hold 5 and you only store 3 unecessary data in memory
            //lists dynamic, add , remove items and modify
            int[] number = new int[2];
            int[] newNumbers = new int[] { 
                1, 2, 3, 4
            };

            List<int> listNumners = new List<int>();
            //{
            //  1, 2, 3,4
            //};
            //listNumners.Add(1);
            //listNumners.Add(2);
            //listNumners.Add(3);
            //listNumners.Add(4);
            //copy 0-1 of numbers into new numbers

                for (int i = 0; i <4; i++)
            {
                Console.Write("Enter a number: ");
                listNumners.Add(Convert.ToInt32(Console.ReadLine()));
            }
            //lists use listnumner.count
            foreach (var item in listNumners)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();



        }
    }
}
