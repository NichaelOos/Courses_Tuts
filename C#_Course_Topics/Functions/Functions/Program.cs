using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Test
    {
        
        public static void something()
        {
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Function can also be called methods, used interchangeably
            //Dry don't repeat yourself
            WelcomeMessage();
            //If function was not static
            Test test = new Test();
            //test.something();
            Test.something();
            Console.ReadLine();
        }

        //Static means we can access it anywhere and everywhere, do not have to make a new instance of program class to add this function
        //Void means it returns nothing
        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome Nika");
        }
    }
}
