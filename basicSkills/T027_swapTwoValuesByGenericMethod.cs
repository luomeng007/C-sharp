/*
Description:
    Aim: teach people how to swap two values by using generic method.
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int a = 1;
            int b = 5;
            // before swap
            Console.WriteLine(a);
            Console.WriteLine(b);
            Swap<int>(ref a, ref b);
            // after swap
            Console.WriteLine(a);
            Console.WriteLine(b);

            float a1 = 1.0f;
            float b1 = 2.0f;
            // before swap
            Console.WriteLine(a1);
            Console.WriteLine(b1);
            Swap<float>(ref a1, ref b1);
            // after swap
            Console.WriteLine(a1);
            Console.WriteLine(b1);
        }
    }
}
