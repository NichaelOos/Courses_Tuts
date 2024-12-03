using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace StringIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "C# is awesome";
            Console.WriteLine(message[1]);
            Console.WriteLine(message[2]);

            for(int i =0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                //delay
                Thread.Sleep(100);
            }
            Console.WriteLine("\n");
            Console.WriteLine(message.Contains("C"));

            bool contains = false;

            for (int i = 0; i < message.Length; i++) 
            {
                if (message[i].Equals('C')) 
                {
                    contains = true;
                }
            }
            Console.WriteLine(contains);
                Console.ReadLine();
        }
    }
}
