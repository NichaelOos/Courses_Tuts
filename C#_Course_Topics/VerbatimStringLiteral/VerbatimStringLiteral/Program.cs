using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerbatimStringLiteral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //\t \n
            //In C# when constructing string you'll need to use doubel'\'
            //Reason: The first '\' is an indication that it's actually going to be an escpae character
            //Escape characters are a slight hint of yellow
            string path = "C:\\Users\\JohnN\\Desktop\\C#\nNew line test";
            Console.WriteLine(path);
            string speech= "Nika said \"something\"";
            path = @"C:\Users\JohnN\Desktop\C#"+"\nNew line test"; //Verbatim identifier

            Console.WriteLine(path);
            Console.WriteLine(speech);

            string name = @"Hello ""something fell of the roof""";
            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
