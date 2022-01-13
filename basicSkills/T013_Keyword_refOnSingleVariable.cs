/*
Description:
    Aim: teach people how to return value from customized function by using keyword "ref".
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int sum = 0;
            Console.WriteLine("The value of a is: {0}", sum);
            Add(a, b, ref sum);
            Console.WriteLine("The value of sum of a and b is: {0}", sum);
        }

        public static void Add(int num1, int num2, ref int num_sum)
        {
            num_sum = num1 + num2;  // this operation will influence the value of sum in main function 
        }
    }
}
