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
        private string name;
        private int age;
        //Now getter and setter functions are needed

        public void setName(string name)
        {
            /*if (!string.IsNullOrEmpty(name))
            {
                this.name = name;
            }
            else
            {
                //If entered value is invallid it does not get assigned
                //this.name = string.Empty;
                this.name = "Invallid name";
            }*/

            this.name = !string.IsNullOrEmpty(name) ? name : "Invallid name";


        }

        public string getName()
        {
            return this.name;
        }

        public void setAge(int age)
        {
            /*if (age >= 0 && age <= 150)
            {
                this.age = age;
            }
            else
            {
                this.age = -1;
            }*/
            // condition ? true : false
            this.age = age >= 0 && age <= 150 ? age : -1;


        }
        //Arrow function version

        // public void setAge(int age) => this.age = age >= 0 && age <= 150 ? age : -1;

        public int getAge()
        {
            return this.age;
        }
        //Arrow function version

        // public int GetAge() => age;
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
    class Program
    {




        static void Main(string[] args)
        {
            Person person = new Person("Nika", 26);
            //Console.WriteLine(ReturnDetails(person));
            Console.WriteLine(person.ReturnDetails());

            //Changing fields of object person
            //This is not the way to do this however
            //person.name = "Kyle";
            //person.age = 27;
            person.setName("");
            person.setAge(160);

            Console.WriteLine(person.ReturnDetails());
            Console.WriteLine($"Your name is {person.getName()} and your age is {person.getAge()}");
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