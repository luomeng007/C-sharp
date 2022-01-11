/*
Description:
    Aim: teach people the function of keyword "Count" in C Sharp.
 */
using System;
using System.Collections.Generic;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1D = new List<int>() { 1, 2 }; // initialize a 1D list with specifying elements
            Console.WriteLine("The number of elements in list1D are: {0}", list1D.Count);
            // By using keyword "Count", we can get the number of elements in 1D list.

            List<List<int>> list2D = new List<List<int>>();   // initialize a 2D list
            List<int> list1 = new List<int> { 1, 2, 3};
            List<int> list2 = new List<int> { 3, 4, 5 };

            list2D.Add(list1);  // use Add Method to add 1D list into 2D list
            list2D.Add(list2);

            Console.WriteLine("The number of rows in list2D are: {0}", list2D.Count);
            // However, By using keyword "Count", we can only get the number of rows in 2D list. If we want to get the total elements in 2D list,
            // we need to use keyword "Capacity".

            //  Extension: for 3D list, By using keyword "Count", we can only get the first dimension of 3D list.
        }
    }
}
