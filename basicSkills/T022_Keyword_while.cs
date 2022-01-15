/*
Description:
    Aim: teach people how to write loop by using keyword "enumerator" and "while".
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3 };
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
