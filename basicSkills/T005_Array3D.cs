/*
Description:
    Aim: teach people the method to generate 3D array
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] array3D = new int[2, 2, 2]; // initialize a 3D array with 2*2*2=8 elements

            array3D[0, 0, 0] = 1;   // set first value of array
            array3D[0, 0, 1] = 2;   // set second value of array
            array3D[0, 1, 0] = 3;   // set third value of array
            array3D[0, 1, 1] = 4;   // set fourth value of array
            array3D[1, 0, 0] = 1;   // set fifth value of array
            array3D[1, 0, 1] = 2;   // set sixth value of array
            array3D[1, 1, 0] = 3;   // set seventh value of array
            array3D[1, 1, 1] = 4;   // set eighth value of array

            Console.WriteLine("The elements in array3D are: ");
            for (int i = 0; i < array3D.GetLength(0); i++)  // loop print all values in array3D
            {
                for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    for (int k = 0; k < array3D.GetLength(2); k++)
                    {
                        Console.WriteLine(array3D[i, j, k]);
                    }
                }
            }
        }
    }
}
