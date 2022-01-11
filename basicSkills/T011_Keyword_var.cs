/*
Description:
    Aim: teach people the function of keyword "var" in C Sharp.
 */
using System;
using System.Collections.Generic;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // If we want to initialize a 3D list. Normally, we need to use:
            List<List<List<int>>> list3D = new List<List<List<int>>>();
            // This expression is too troublesome, so we could use keyword "var" here to simplify this expression.
            var list3D_1 = new List<List<List<int>>>();
            // Is this very convenient?

            // For all statement, we can use this form, we will give several examples below:
            var array1D = new int[2];
            var array2D = new int[2, 2];
            var array3D = new int[2, 2, 2];

            var array1D_1 = new int[]{ 1, 2 };
        }
    }
}
