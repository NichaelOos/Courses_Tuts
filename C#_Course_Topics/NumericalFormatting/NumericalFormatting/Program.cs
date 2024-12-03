using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double val = 1000D / 12.34D;
            Console.WriteLine(val);
            //All number infront of decimal will be displayed while 2 numbers after decimal will be displayed (rounded)
            Console.WriteLine(string.Format("{0:0}",val));
            Console.WriteLine(string.Format("{0:0.0}", val));
            //will keep in format 0.0 except when last number is a 0
            Console.WriteLine(string.Format("{0:0.#}", val));
            Console.WriteLine(string.Format("{0:0.00}", val));

            double money = 10D / 3D; //3.3333333...
            Console.WriteLine(String.Format("${0:0.00}", money));


            double money2 = -10D / 3D; //3.3333333...
            //The "-" sign is after the currency symbol which is undesirable
            Console.WriteLine(String.Format("${0:0.00}", money2));
            //c# recognize that the format of "C" is saying that we want to display currency, digures out currency of local
            Console.WriteLine(money2.ToString("C"));
            Console.WriteLine(money2.ToString("C0")); //wholenumber
            Console.WriteLine(money2.ToString("C1")); //returns 1 decimal
            Console.WriteLine(money2.ToString("C2")); //returns 2 decimal

            //displaying different currency
            //retrieve different currency formats depending on a given country code
            //current culture based in machine the program is running on avoid when scaling program ww
            Console.WriteLine(money2.ToString("C",CultureInfo.CurrentCulture));
            Console.WriteLine(money2.ToString("C", CultureInfo.CreateSpecificCulture("en_GB")));
            Console.WriteLine(money2.ToString("C", CultureInfo.CreateSpecificCulture("en_US")));
            Console.ReadLine();
        }
    }
}
