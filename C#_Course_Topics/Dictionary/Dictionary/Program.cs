using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dictionary stores key value pairs in no particular order
            //key value can be any datatype
            //Keys need be unique and never null, values can be similar and null

            /*Dictionary<int, string> names = new Dictionary<int, string> 
            {
                //Key value-pairs
                { 1, "Nichael"},
                { 2, "Nika"},
                { 3, "Nichael"}
            };

            for (int i = 0; i < names.Count; i++) 
            {
                //key-look-up not index look-up
                //Console.WriteLine(names[i]);
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key} - {pair.Value}");
                

            }

            foreach (KeyValuePair<int, string> item in names)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            ;*/

            Dictionary<string, string> teacher = new Dictionary<string, string>
            {
                { "Math","Kyle"},
                { "Biology","Nika"},
                { "Physics","Nichael"},
            };
            //Does search on key math
            //Not found exception thrown
            //Console.WriteLine(teacher["Can"]);

            //Check if key exists first before using it

            if (teacher.TryGetValue("Math", out string teach))
            {
                Console.WriteLine(teach);
                teacher["Math"] = "Driaan";
            }
            else 
            {
                Console.WriteLine("Techer not found");
            }

            foreach (var item in teacher)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            //Deleting value from dictionary
            //Will not throw an exception, gives back bool
            //teacher.Remove(teach);
            //Alternatively
            if (teacher.ContainsKey("Math"))
            {
                teacher.Remove("Math");
            }
            else 
            {
                Console.WriteLine("Subject no rizz");
            }
            {
                
            }

            Console.ReadLine();
        }
    }
}
