using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pass by reference uses one variable memory location
            //Using the out keyword the variable has to be aagned but using ref this is not the case
            //passing by reference is better for efficiency
            /* int num = 10;
             string name = "Nika";
             Assign(ref num, ref name);
             Console.WriteLine(num);
             Console.WriteLine(name);*/

            string name = "Kyle";

            Console.Write("Enter your new name: ");
            string newName = Console.ReadLine();
            if (ChangeName(ref name, newName))
            {
                Console.WriteLine($"Your new name is {name}");
            }
            else
            {
                Console.WriteLine("New name cannot be empty or null");
            }
            
            Console.ReadLine();
        }


        static bool ChangeName(ref string name, string NewName)
        {
            if (!string.IsNullOrEmpty(NewName))
            {
                name = NewName;
                return true;
            }
            return false;
   
           
        }

        static void Assign(ref int num, ref string name)
        {
            name = "nika";
            num = 20; // not needed when using ref
        }
    }
}
