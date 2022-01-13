/*
Description:
    Aim: teach people how to print result in a good format.
 */
using System;
using System.Collections.Generic;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3 };
            // Method one----Like "f string" method in Python"
            foreach (var a in array)
            {
                Console.WriteLine($"A is {a}");
            }
            // Method two----Like "format method" in Python);
            foreach (var a in array) ");
            foreach (var a in array)
            {
                Console.WriteLine("A is {0}", a);
            }
            // Mehtod three----Like string concatenate method);
            foreach (var a in array)
            {
                Console.WriteLine("A is " + a.ToString());
            }
            // Method four----Like "format method" in Python);
            // same as method 2, but here keyword "String.Format" is leaved out.
            foreach (var a in array)
            {
                Console.WriteLine(String.Format("A is {0}", a));
            }
        }
    }
}
