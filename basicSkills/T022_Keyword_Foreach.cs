/*
Description:
    Aim: teach people how to write loop by using keyword "foreach".
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3 };
            foreach (var a in array)
            {
                Console.WriteLine($"A is {a}");

            }
        }
    }
}
