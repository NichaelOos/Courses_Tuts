using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnTypeFunction
{
   
    internal class Program
    {
        //static string name = "Nika"; //Global Variable - Not good
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            Console.Title = ReturnNameAgePair();
            PrintIntroduction();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ReadNumbeFromConsole();
            }

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }

            int[] newNumbers = CreateRandomArray();

            foreach (var item in newNumbers)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }

        //Goal of functions are to make them do as little as possible
        //Specify function tasks
        
        static void conversion()
        {
            //conversion
        }

        static void calculation()
        {
            //calculation
        }
        //Returns array
        static int[] CreateRandomArray()
        {

            return new int[3] { 4,5, 6};
        }
        static int ReadNumbeFromConsole()
        {
            Console.Write("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static string ReturnName() 
        {
            return "Nika";
        }

        static int Age()
        {
            return 26;
        }

        static string ReturnNameAgePair()
        {
            return $"{ReturnName()} - {Age()}";
        }

        static void PrintIntroduction()
        {
            Console.WriteLine($"Hello my name is {ReturnName()} and my age is {Age()}");
        }
    }
}
