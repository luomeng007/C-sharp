/*
Description:
    Aim: teach people to print in an elegant way
    
    Before, we talked about print function, but usually, we want to print things with some tips. Not only the variables themselves.

 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine("The value of a is: {0}", a); // only one variable
            int b = 6;
            Console.WriteLine("The values of a and b are {0} and {1} respectively.", a, b); // two variables
            // here, we use comma to separate variable a and b when we do print procedure.
        }
    }
}
