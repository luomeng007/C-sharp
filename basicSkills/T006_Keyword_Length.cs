/*
Description:
    Aim: teach people the function of keyword "Length" in C Sharp.
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[2,2];  // initialize a 2D array with 2*2=4 elements
            Console.WriteLine("The total element in array2D is: {0}", array2D.Length);  // like keyword "size" in Python
        }
    }
}
