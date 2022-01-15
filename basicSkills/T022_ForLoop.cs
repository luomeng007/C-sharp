/*
Description:
    Aim: teach people how to write loop by using keyword "for".
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
        }
    }
}
