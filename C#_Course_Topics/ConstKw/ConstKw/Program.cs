using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstKw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int vat = 20; //prohibits change later in code, local constant
            const double percentVAT = vat / 100D;
            int balance = 1000;

            Console.WriteLine(balance*percentVAT);
            Console.ReadLine();
        }
    }
}
