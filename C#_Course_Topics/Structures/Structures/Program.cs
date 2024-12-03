using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Structures
{
    internal class Program
    {
        struct Person
        {   //access modifier public needed
            public string name;
            public  int age;
            public int birthMonth;

            //Constructor
            public Person(string name, int age, int birthMonth)
            { 
                this.name = name;
                this.age = age;
                this.birthMonth = birthMonth;

            }
        }
        static void Main(string[] args)
        {
            //Structures allows for the storage of different dtypes inside 1 data type
            //Eg person:
            /*string name = "Nika";
            int age = 26;

            Person person;

            person.name = name;
            person.age = age;
            person.birthMonth = 6;

            Console.WriteLine($"{person.name} - {person.age} - {person.birthMonth}");

            string newName = "";
            int newAge = 0;
            int newBirthMonth = 0;
            ReturnPerson(ref newName, ref newAge, ref newBirthMonth);
            Console.WriteLine($"{newName} - {newAge} - {newBirthMonth}");
            */
            Person person = ReturnPerson();
            Console.WriteLine($"{person.name} - {person.age} - {person.birthMonth}");
            Console.ReadLine();


        }
        static Person ReturnPerson()
        {
            Console.Write("enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your birthmonth: ");
            int BirthMonth = Convert.ToInt32(Console.ReadLine());

            //Create new person

            /*Person person;
            person.name = name;
            person.age = age;
            person.birthMonth = BirthMonth;

            return person;*/
            //New Instance
            return new Person(name, age, BirthMonth);
        }
        //2 output variables, return string and out age
        /*static void ReturnPerson(ref string name,ref int age, ref int BirthMonth)
        {
            Console.Write("enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your birthmonth: ");
            BirthMonth = Convert.ToInt32(Console.ReadLine());


        }*/
    }
}
