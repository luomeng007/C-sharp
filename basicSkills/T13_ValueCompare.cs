/*
Description:
    Aim: teach people how to compare two values.
    
    a.CompareTo(b)
    if a > b: return 1
    if a < b: return -1
    if a = b; return 0
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

            Console.WriteLine(a.CompareTo(b));
            Console.WriteLine(b.CompareTo(a));
            Console.WriteLine(a.CompareTo(c));

            float d = 1.1F;
            float e = 1.1F;
            Console.WriteLine(d.CompareTo(e));
            Console.WriteLine(((float)a).CompareTo(d)); // The type of variables a and b must be same.
        }
    }
}
