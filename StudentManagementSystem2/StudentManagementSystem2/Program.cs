using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentManagementSystem2
{
    internal class Program
    {
        public class Student
        {
            private string name;
            private int age;
            private int studentId;
            private double gpa;

            // Property for Name with validation
            public string Name
            {
                get => name;
                set
                {
                    // Exclude special characters and numbers
                    if (System.Text.RegularExpressions.Regex.IsMatch(value, @"^[a-zA-Z\s]+$"))
                        name = value;
                    else
                        throw new ArgumentException("Name must contain only letters and spaces.");
                }
            }

            // Property for Age with validation
            public int Age
            {
                get => age;
                set
                {
                    if (value >= 0 && value <= 120)
                        age = value;
                    else
                        throw new ArgumentException("Age must be a non-negative integer and realistically not greater than 120.");
                }
            }

            // Property for Student ID with validation
            public int StudentId
            {
                get => studentId;
                set
                {
                    if (value > 0 && value.ToString().Length >= 6 && value.ToString().Length <= 8)
                        studentId = value;
                    else
                        throw new ArgumentException("Student ID must be a positive integer with a realistic number of digits (6-8).");
                }
            }

            // Property for GPA with validation
            public double GPA
            {
                get => gpa;
                set
                {
                    if (value >= 0 && value <= 100)
                        gpa = value;
                    else
                        throw new ArgumentException("GPA must be a non-negative value realistically not greater than 100.");
                }
            }

            // Method to prompt user for input and assign values
            public void GetStudentDetails()
            {
                Console.Write("Enter Name: ");
                while (true)
                {
                    try
                    {
                        Name = Console.ReadLine();
                        break;
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.Write("Please re-enter a valid Name: ");
                    }
                }

                Console.Write("Enter Age: ");
                while (true)
                {
                    try
                    {
                        Age = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter a valid Age as a non-negative integer (0-120).");
                    }
                }

                Console.Write("Enter Student ID: ");
                while (true)
                {
                    try
                    {
                        StudentId = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter a valid Student ID as a positive integer with 6-8 digits.");
                    }
                }

                Console.Write("Enter GPA: ");
                while (true)
                {
                    try
                    {
                        GPA = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter a valid GPA between 0 and 100.");
                    }
                }
            }

            public void DisplayStudentDetails()
            {
                Console.WriteLine($"\nStudent Details:");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {Age}");
                Console.WriteLine($"Student ID: {StudentId}");
                Console.WriteLine($"GPA: {GPA}\n");
            }
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Console.Write("How many students do you want to add? ");
            int numStudents;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out numStudents) && numStudents > 0)
                    break;
                else
                    Console.Write("Please enter a valid positive number of students to add: ");
            }

            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"\nEntering details for student {i + 1}:");
                Student student = new Student();
                student.GetStudentDetails();
                students.Add(student);
            }

            Console.WriteLine("\n--- Students Added to the System ---");
            foreach (var student in students)
            {
                student.DisplayStudentDetails();
            }



            Console.ReadLine();


        }


    }
}
