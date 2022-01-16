/*
Description:
    Aim: teach people how to convert data type by using keyword like "int", "float", "double" and so on.
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            float b = 2.0f;
            double d = 3.0;
            // use keywod float to convert data type
            float b1 = (float)a;
            Console.WriteLine(b1.GetType());
            int a1 = (int)b;
            Console.WriteLine(a1.GetType());
            float b2 = (float)d;
            Console.WriteLine(b2.GetType());

            char c = 'c';
            string s = "sss";
            // however, if we want to convert char to string, we shoul not use string s1 = (string)c.
            // instead, we should use string s1 = c.ToString();
            string s1 = c.ToString();
            Console.WriteLine(s1.GetType());
        }
    }
}
