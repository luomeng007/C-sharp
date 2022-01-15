/*
Description:
    Aim: teach people how to use keyword "const".
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            const int a = 3;
            // When we set variable as a const. We cannot change the value of it any more. 
            // Or we will get an error.
            // In another words, once the const variable is set. It keeps that value.
            a = 5;
        }
    }
}
