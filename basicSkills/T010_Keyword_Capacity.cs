/*
Description:
    Aim: teach people the function of keyword "Capacity" in C Sharp.
 */
using System;
using System.Collections.Generic;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1D_1 = new List<int>(2);
            Console.WriteLine("The number of elements in list1D are: {0}", list1D_1.Capacity);
            // when we intialize list1D_1, we set the capacity as 2, so here the output capacity is 2.

            List<int> list1D_2 = new List<int>() { 1, 2}; // initialize a 1D list with specifying elements
            Console.WriteLine("The number of elements in list1D are: {0}", list1D_2.Capacity);
            // We did not set capacity at initialization, and we only specified two elements at intialization, so the computer will choose default capacity---4.
            // If we increase the number of elements in list1D_2 at initialization, like 5 elements, we will get default capacity---8
            // If we increase the number of elements in list1D_2 at initialization, like 9 elements, we will get default capacity---16
            // You can have a try here to test that.

            List<List<int>> list2D = new List<List<int>>(2);   // initialize a 2D list
            List<int> list1 = new List<int> { 1, 2, 3};
            List<int> list2 = new List<int> { 3, 4, 5};

            list2D.Add(list1);  // use Add Method to add 1D list into 2D list
            list2D.Add(list2);

            Console.WriteLine("The number of rows in list2D are: {0}", list2D.Capacity);
            // For 2D list, if we have given the capacity of rows at initialization, by using keyword "Capacity", we can get the capacity of rows.
            // If we give the capacity of rows at initialization, If we can use code below to get the total number of elements in 2D list.
            Console.WriteLine("The total number of elements in list2D are: {0}", list2D.Capacity * list2.Count);

            // If we do not give the capacity of rows at initialization, we need to add the number of elements in each 1D list to get the total number of elements in 2D list.
            Console.WriteLine("The total number of elements in list2D are: {0}", list1.Count + list2.Count);

            //  Extension: for 3D list, By using keyword "Capacity", we can only get the first dimension of 3D list.
        }
    }
}
