using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converting_string_to_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string TextAge = "23";
            int age = Convert.ToInt32(TextAge); //passes string to function Convert.ToInt32
            Console.WriteLine(age);

            string TextBigNum = "900000000";
            long bigNumber = Convert.ToInt64(TextBigNum);
            Console.WriteLine(bigNumber);

            string Textnegative = "-55,2";
            double negative = Convert.ToDouble(Textnegative);
            Console.WriteLine(negative);

            string floatNum = "8,0001";
            float precision = Convert.ToSingle(floatNum);
            Console.WriteLine(precision);

            string decNum = "14,99";
            decimal money = Convert.ToDecimal(decNum);
            Console.WriteLine(money);

            Console.ReadLine();
        }
    }
}
