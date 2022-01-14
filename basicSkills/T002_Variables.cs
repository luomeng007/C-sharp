/*
Description:
    Aim: teach people to know basic variables in c sharp

    Like stirng, char, int, float and double
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example one: string
            // Method one:
            string name;                        // Initialize a string variable---name
            name = "John";                      // assign variable name with a value "John"
            Console.WriteLine(name);            // print the value of variable name 
            // Method Two:
            string name1 = "John";              // Initialize a string variable name1 and assign it with value "John".
            Console.WriteLine(name1);           // print the value of variable name1
            // Method Three:
            string name2 = new string("John");  // Initialize a string variable name2 and assign it with value "John".
            Console.WriteLine(name2);           // print the value of variable name2
            // Method three is totally same as method two, and method two is a simple method for initialization.

            // Example two: integer
            // Method one:
            int myNum;                          // Initialize a integer variable---myNum
            myNum = 1;                          // assign variable name with a value 1
            Console.WriteLine(myNum);           // print the value of variable myNum2 
            // Method Two:
            int myNum1 = 1;                     // Initialize a integer variable myNum1 and assign it with value 1.
            Console.WriteLine(myNum1);          // print the value of variable myNum1
            // Method Three:
            int myNum2 = new int();             // Initialize a integer variable myNum2.
            myNum2 = 1;                         // assign it with value 1.
            Console.WriteLine(myNum2);          // print the value of variable myNum2

            // Example three: Char
            // like three method of integer, here, we directly give them
            char c;
            c = 'c';                             // Method one
            Console.WriteLine(c);
            char c1 = 'c';                       // Method two
            Console.WriteLine(c1);
            char c2 = new char();                // Method three
            c2 = 'c';
            Console.WriteLine(c2);

            // Example four: float
            float f;
            f = 1.0f;                             // Method one
            Console.WriteLine(f);
            float f1 = 1.0f;                      // Method two
            Console.WriteLine(f1);
            float f2 = new float();               // Method three
            f2 = 1.0f;
            Console.WriteLine(f2);
            // When we assign float variable, we need to add characters 'f' or 'F' behind digits.

            // Example Five: double
            double d;
            d = 1.0;                              // Method one
            Console.WriteLine(d);
            double d1 = 1.0;                      // Method two
            Console.WriteLine(d1);
            double d2 = new double();             // Method three
            d2 = 1.0;
            Console.WriteLine(d2);
        }
    }
}
