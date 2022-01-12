/*
Description:
    Aim: teach people how to compare two values by using comparision operator.
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
            int c = 1;

            Console.WriteLine(a > b);   //  return False
            Console.WriteLine(a < b);   //  return True
            Console.WriteLine(a == c);  //  return True

            float d = 1.1F;
            float e = 2.0F;
            float f = 1.1F;

            Console.WriteLine(d > e);   //  return False
            Console.WriteLine(d < e);   //  return True
            Console.WriteLine(d == f);  //  return True
        }
    }
}
