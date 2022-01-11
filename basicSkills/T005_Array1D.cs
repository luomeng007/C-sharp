/*
Description:
    Aim: teach people the method to generate 1D array
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1D = new int[2]; // initialize a 1D array with 2 elements

            array1D[0] = 1; // set first value of array
            array1D[1] = 2; // set second value of array

            Console.WriteLine("The elements in array1D are: ");
            for (int i = 0; i < array1D.GetLength(0); i++)  // loop print all values in array1D
            {
                Console.WriteLine(array1D[i]);  
            }
        }
    }
}
