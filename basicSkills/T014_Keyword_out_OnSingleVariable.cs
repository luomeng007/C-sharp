/*
Description:
    Aim: teach people how to return value from customized function by using keyword "out".

    use keyword "out" on single value.
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
            Add(a, b, out int sum);
            // When we use "out" keyword, wo do not need to initialize parameters before we pass them to the calling function
            // This differs from keyword "ref". Of course we can do it like the way below.
            // int sum = 0; 
            // Add(a, b, out sum);
            Console.WriteLine("The value of sum of a and b is: {0}", sum);
        }

        public static void Add(int num1, int num2, out int num_sum)
        {
            num_sum = num1 + num2;  // this operation will influence the value of sum in main function 
        }
    }
}
