using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTriangle
{
    internal class Program
    {
        /*
         * Ask user for width and height store them
         * Create function to calculate the area of the triangle
         * Function should calculate the area using: (width * height)/2
         * Call in main and print out the area of the triangle
         */
        static void Main(string[] args)
        {

            double width = ReadParam("Enter width: ");
            double height = ReadParam("Enter height: ");
            Console.Write($"The area of the triangle is {TriangleArea(height, width)}");
            Console.ReadLine();

        }

        //Function asking user input and storing them as parameters
        static double ReadParam(string message)    
        {
            Console.Write(message);
            return Convert.ToDouble(Console.ReadLine());
        }

        //Function to calculate area from the input parameters
        static double TriangleArea(double width, double height) 
        {
            return width * height * 1 / 2;
        }
    }
}
