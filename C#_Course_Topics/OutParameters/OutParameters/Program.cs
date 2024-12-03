using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            test(out num);
            Console.WriteLine(num);
            //Console.WriteLine(success);
            List<string> shoppingList = new List<string>
            {
                "Coffee", "Milk"
            };

           
            Console.WriteLine(shoppingList.IndexOf("Milk"));
            //Console.WriteLine(FindInlIst("Milk", shoppingList, out int index));
            //Console.WriteLine(""+index);
            //Console.WriteLine(found? "Found":"Not Found");
            Console.WriteLine("Enter an item to search: ");
            string s= Console.ReadLine();
            if (FindInlIst(s, shoppingList, out int index))
            {
                Console.WriteLine($"Found {s} at index {index}");
            }
            else 
            {
                Console.WriteLine($"{s} not found");
            }


            Console.ReadLine();
        }


        static bool FindInlIst(string s, List<string> list, out int index)

        {
            index = -1;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToLower().Equals(s.ToLower()))
                {
                    index = i;
                }
            }

            return index > -1;
        }

        //Rewrite TryPass

        static bool TryParse(string s, out int result)
        {
            result = 0;
            return true;
        }

        static void test(out int num)
        {
            num = 5;
            
        }
    }
}
