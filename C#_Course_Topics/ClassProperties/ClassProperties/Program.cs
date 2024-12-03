using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassFunctions
{

    class Person
    {
        //AUTO PROPERTY
        //MAKE PUBLIC AGAIN
        public string Name { get; set; }
        public int Age { get; set; }

        /*public string Name
        { 
            get => name;
            set => name = !string.IsNullOrEmpty(value) ? value : "Invallid";
        }
        //public string Name { get => name; set => name = value; }
        public int Age
        {
            get=> age;
            set => age = value >= 0 && value <= 150 ? value : -1;
        }
        //public int Age { get => age; set => age = value; }
        */
        public Person(string name, int age) 
        {
            Name = name;
            Age = age;
        }


        public string ReturnDetails()
        {
            return $"Name: {Name}\nAge: {Age}";
        }

    
    }
    class Program
    {

        static void Main(string[] args)
        {
            Person person = new Person("Nika", 26);
            //Console.WriteLine(ReturnDetails(person));
            Console.WriteLine(person.ReturnDetails());
            person.Name = "Kyle";
            person.Age = 27;
            Console.WriteLine(person.ReturnDetails());
            Console.WriteLine($"Your name is {person.Name} and your age is {person.Age}");
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