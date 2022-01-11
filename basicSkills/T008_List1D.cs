/*
Description:
    Aim: teach people how to generate 1D list

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
            // method 1:
            var list1D = new List<int>(); // initialize a 1D list
            // method 2:
            var _list1D = new List<int> { 1, 2 };

            Console.WriteLine("The elements in _list1D are: ");
            for (int i = 0; i < _list1D.Count; i++)  // loop print all values in _list1D
            {
                Console.WriteLine(_list1D[i]);
            }
        }
    }
}
