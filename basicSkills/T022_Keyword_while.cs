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
            int i = 0;
            while (i < array.GetLength(0))
            {
                // print each element
                Console.WriteLine($"A is {array[i]}");
                i++;
            }
        }
    }
}
