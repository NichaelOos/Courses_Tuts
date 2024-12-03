using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameInput = "Nika";
            int ageInput = 26;
            string addressInput = "12 Beach rd";
            PrintDetails(age:ageInput,
                name:nameInput,
                address:addressInput);

            Console.ReadLine();

        }
        static void PrintDetails(string name, int age, string address)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Address: {address}");
        }
    }
}
