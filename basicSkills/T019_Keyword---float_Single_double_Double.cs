/*
Description:
    Aim: tell differneces between keyword "float", "Single", "double" and "Double".

    Conclusion: "float" and "Single" are equal. While "double" and "Double" are same.
    However, in C#, we prefer using "float" and "double" as keyword.
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            float x1 = 7.6767f;
            Single x2 = 7.6768F;
            double x3 = 7.67687897897;
            Double x4 = 7.67687897897;
            
            Console.WriteLine(x1.GetType());
            Console.WriteLine(x2.GetType());
            // The above two will give same results

            Console.WriteLine(x3.GetType());
            Console.WriteLine(x4.GetType());
            // The above two will give same results
        }
    }
}
