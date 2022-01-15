/*
Description:
    Aim: teach people how to use keyword "if".
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            if (a > b) 
            {
                Console.WriteLine("a is greater than b");
            }
            else 
            {
                Console.WriteLine("b is greater than a");
            }
        }
    }
}
