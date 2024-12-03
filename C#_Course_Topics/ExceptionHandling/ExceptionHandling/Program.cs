using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool looping = true;

            while (looping) 
            {
                try
                {
                    //System.FormatException
                    //System.OverflowException
                    Console.Write("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    looping = false;
                    Console.WriteLine(num);
                }
                catch (FormatException)
                {
                    Console.WriteLine("PLease only enter numbers");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Please enter a number less than 2 billion");
                }
                //Have the general catch exception at the end
                catch (Exception)
                {
                    Console.WriteLine("Something has went wrong");

                }

            }

            
            Console.ReadLine();
        }
    }
}
