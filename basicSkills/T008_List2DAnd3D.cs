/*
Description:
    Aim: teach people how to generate 2D and 3D list

    List method belongs to "System.Collections.Generic" package, we need to add this package at the beginning of our code
 */
using System;
using System.Collections.Generic;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate 2D list
            List<List<int>> list2D = new List<List<int>>();   // initialize a 2D list
            List<int> list1 = new List<int> { 1, 2 };
            List<int> list2 = new List<int> { 3, 4 };

            list2D.Add(list1);  // use Add Method to add 1D list into 2D list
            list2D.Add(list2);

            Console.WriteLine("The elements in list2D are: ");
            for (int i = 0; i < list2D.Count; i++)    // loop print all values in list2D
            {
                for (int j = 0; j < list1.Count; j++)
                {
                    Console.WriteLine(list2D[i][j]);
                }
            }

            // Generate 3D list
            List<List<List<int>>> list3D = new List<List<List<int>>>();
            // the method for generating 3D list is similar at the method for generating 2D list. We can use loop-print method to print each element in list3D on our screen
        }
    }
}
