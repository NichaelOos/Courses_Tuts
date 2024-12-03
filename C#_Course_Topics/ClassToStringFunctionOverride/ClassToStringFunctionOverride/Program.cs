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
        private string name;
        private int age;
        public string Name
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
        /*
        //public int Age { get => age; set => age = value; }
        */
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }


       /* public string ReturnDetails()
        {
            return $"Name: {Name}\tAge: {Age}";
        }*/

        public override string ToString()
        {
            return $"Name: {Name}\tage: {Age}";
        }

        public override bool Equals(object obj)
        {   //Checks wether the object is infact a Person object, since when compiling input such as int or double etc... will be compiled
            //without errrors
            if (obj is Person)
            {   //sets object to person object
                Person person = obj as Person;
                return Name.Equals(person.Name) && Age == person.Age;
            }

            //returns false if obj is not of type person

            return false;
        }




    }
    class Program
    {

        static void Main(string[] args)
        {
            Person person = new Person("Nika", 26);
            Person test = new Person("Nika", 26);
            //Console.WriteLine(ReturnDetails(person));
            //Console.WriteLine(person.ReturnDetails());
            //Console.WriteLine(person.ToString());
            Console.WriteLine(person);

            if (person.Equals(5D))
            {
                Console.WriteLine("same");
            }
            else
            {
                Console.WriteLine("not the same");
            }
            Console.ReadLine();

        }
    }
}
