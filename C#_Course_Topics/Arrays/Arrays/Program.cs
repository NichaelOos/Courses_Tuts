using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //want integer array
            //call it angles
            //instiate integer array with 3 positions
            int[] angles = new int[3]; //this three is known as a magic number, decreases readability
            angles[0] = 20;
            angles[1] = 100;
            angles[2] = 60;

            Console.WriteLine($"{angles[0]} {angles[1]} {angles[2]}");

            int[] input2 = new int[3];


            for (int i = 0; i < input2.Length; i++)
            {
                Console.Write($"Enter a angle {i+1}: ");
                input2 [i] = Convert.ToInt32(Console.ReadLine());
            }

            //Console.WriteLine($"{input2[0]} {input2[1]} {input2[2]}");

            for (int i = 0; i < input2.Length; i++)
            {
                Console.Write($"{input2[i]} ");
            }

            Console.WriteLine();

            foreach (int num in input2)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();

            int sum = 0;

            foreach (int num in input2) 
            {
                sum += num;
            }

            if (sum == 180)
            {
                Console.WriteLine("valid triangle");
            }
            else
            {
                Console.WriteLine("Invalid angles");
             }


            Console.WriteLine(sum==180? "Valid":"Invalid");
            Console.ReadLine();

        }
    }
}
