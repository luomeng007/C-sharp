/*
Description:
    Aim: teach people the default value of variables in c sharp is 0.
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = default;
            float x1 = default;
            double x2 = default;

            Console.WriteLine("The value of x is {0}", x);
            Console.WriteLine("The value of x1 is {0}", x1);
            Console.WriteLine("The value of x2 is {0}", x2);
        }
    }
}
//result:
//The value of x is 0
//The value of x1 is 0
//The value of x2 is 0
