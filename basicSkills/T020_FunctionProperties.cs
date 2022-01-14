/*
Description:
    Aim: teach people how to use properties of a function

    The method of calling attribute:
        Property attr = new Property();
        Console.WriteLine(attr.Age);
        Console.WriteLine(attr.Name);
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine(student.Age);
            Console.WriteLine(student.Name);
        }

        class Student
        {
            private int age = 26;   // Initialization of variable age
            private string name = "Xiao Ming";

            // the first attribute
            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    age = value;
                }
            }
            // the second attribute
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
        }
    }
}
