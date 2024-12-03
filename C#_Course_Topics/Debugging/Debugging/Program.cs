using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Nika";
            int age; 
            age = 26;

            PrintDetails(name, age);

            string message = ReadFromConsole("Enter anything: ");
            Console.WriteLine(message);
        }
        static string ReadFromConsole(string message) 
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        static void PrintDetails(string name, int age)
        {
            Console.WriteLine($"{name} - {age}");
            Console.WriteLine($"{name} - {age}");
            Console.WriteLine($"{name} - {age}");
        }
    }
}
