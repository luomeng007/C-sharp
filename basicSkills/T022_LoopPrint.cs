/*
Description:
    Aim: teach people how to print by using loop.
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3 };
            // Method one: loop print element in array.
            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"A is {array[i]}");
            }

            // Method two: loop print element in array.
            foreach (var a in array)
            {
                Console.WriteLine($"A is {a}");

            }

            // Method three: loop print element in array.         
            var enumerator = array.GetEnumerator(); // create an enumerator contain array
            // if we could reach the next position of enumerator
            while (enumerator.MoveNext())
            {
                // print element in current position
                Console.WriteLine($"A is {enumerator.Current}");
            }
        }
    }
}
