using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecker
{
    internal class Program
    {
        /*
         * Ask the user to enter password, and store
         * Ask the user to enter password again
         * Check if they both contain something
         * If so check if they are the same
         *If they are print passwords match
         *Not, Passwords do not match
         *If they are empry, print "Please enter a a password"
         */
        static void Main(string[] args)
        {
            bool pass = false;
            while (!pass) 
            {
                Console.Write("Please enter a password: ");
                string password = Console.ReadLine();
                Console.Write("Please confirm your password: ");
                string passwordconf = Console.ReadLine();

                if (!string.IsNullOrEmpty(passwordconf) && !string.IsNullOrEmpty(password))
                {
                    pass = true;
                    if (password.Equals(passwordconf))
                    {
                        Console.WriteLine("Passwords Match");
                    }
                    else
                    {
                        Console.WriteLine("Passwords do not match");
                    }
                    {

                    }
                }
                //else
                //{

                //}
            }

            Console.ReadLine();

        }
    }
}
