/*
Description:
    Aim: teach people the function of keyword "GetLength" in C Sharp.
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[2,2];  // initialize a 2D array with 2*2=4 elements
            Console.WriteLine("The shape of array2D is: ({0}, {1})", array2D.GetLength(0), array2D.GetLength(0));  // like keyword "shape" in Python
            // array2D.GetLength(0) represents the number of rows array2D contains
            // array2D.GetLength(1) represents the number of columns array2D contains
            // extension: If we have a 3D array here, GetLength(2) represents the third dimension of array.
        }
    }
}
