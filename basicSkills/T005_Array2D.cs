/*
Description:
    Aim: teach people the method to generate 2D array
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[2, 2]; // initialize a 2D array with 2*2=4 elements

            array2D[0, 0] = 1;  // set first value of array
            array2D[0, 1] = 2;  // set second value of array
            array2D[1, 0] = 3;  // set third value of array
            array2D[1, 1] = 4;  // set fourth value of array

            Console.WriteLine("The elements in array2D are: ");
            for (int i = 0; i < array2D.GetLength(0); i++)  // loop print all values in array2D
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.WriteLine(array2D[i, j]);
                }
            }
        }
    }
}
