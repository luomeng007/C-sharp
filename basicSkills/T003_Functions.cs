/*
Description:
    Aim: teach people to create fucntions

    Here, we have created a function named Add()， and use it to calculate the sum value of integer a and integer b.
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        public static int Add(int a, int b)
        {
            int sum = a + b;

            return sum;
        }
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            int c = Add(a, b);
            Console.WriteLine(a + b);
        }
    }
}
