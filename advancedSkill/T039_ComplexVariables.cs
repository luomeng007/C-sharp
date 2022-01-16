/*
Description:
    Aim: teach people how to create complex variables.
 */
using System;
using System.Numerics;  // package contains keyword "complex"

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(1, 1);
            Console.WriteLine("The value of c1 is {0}:", c1);
            Complex c2 = new Complex(1, 0);
            Complex c3 = new Complex(0, 1);
            Complex c4 = c1 + c2;
            Complex c5 = c1 + c3;
            Console.WriteLine("The value of c4 is {0}:", c4);
            Console.WriteLine("The value of c5 is {0}:", c5);
            Complex c6 = new Complex(1, -1);
            Complex c7 = new Complex(0, 1);
            Complex c8 = c1 * c6;
            Complex c9 = c1 * c7;
            Console.WriteLine("The value of c8 is {0}:", c8);
            Console.WriteLine("The value of c9 is {0}:", c9);
            double num1 = 10;
            double num2 = 20;
            Complex c10 = c1 + num1;
            Complex c11 = c1 + num2;
            Console.WriteLine("The value of c10 is {0}:", c10);
            Console.WriteLine("The value of c11 is {0}:", c11);
        }
    }
}
