using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassFunctions
{
     class Program
    {

        class Person
        {
            public string name;
            public int age;
         

            public Person(string name, int age) 
            {
                this.name = name;
                this.age = age;
               
            }

            //Do not have parameters since it is called directly on the person
            //Can't run function below in the main since its local
            public string ReturnDetails()
            {
                return $"Name: {name}\nAge: {age}";
            }
        }

          
        static void Main(string[] args)
        {
            Person person = new Person("Nika", 26);
            //Console.WriteLine(ReturnDetails(person));
            Console.WriteLine(person.ReturnDetails());
            Console.ReadLine();

        }

        /*static string ReturnDetails(string name, int age)
        {
            return $"Name: {name}\nAge: {age}";
        }*/

        /*static string ReturnDetails(Person person)
        {
            return $"Name: {person.name}\nAge: {person.age}";
        }*/
    }
}
