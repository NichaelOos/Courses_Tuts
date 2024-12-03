using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {   //Used as a dtype
        /* struct Person
         {
             public string name;
             public int age;

             public Person(string name, int age)
             {
                 this.name = name;
                 this.age = age;
             }
         }*/

        class Person
        {
            public string name;
            public int age;

            //Created 4 different constructors
            public Person()
            {
                
            }
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public Person(string name)
            {
                this.name = name;
                this.age = -1;
            }
            public Person(int age)
            {
                
                this.age = age;
                this.name = "";
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person("Nika"); //Empty person
;

            Console.WriteLine(person.name);
            Console.WriteLine(person.age);
            Console.ReadLine();
        }
    }
}
