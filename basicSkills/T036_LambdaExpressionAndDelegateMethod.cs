/*
Description:
    Aim: teach people how to use lambda expression and delegate method.
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        delegate int Mydel(int x); // Declares a delegate named Mydel that takes int as an argument and returns int.

        static void Main(string[] args)
        {

            Mydel del = x => x + 1; // Instantiate a delegate method named del. And use lambda function to set its value as x+1 
            Console.WriteLine($"{del(10)}");    // finally, we will get 11
        }
    }
}
//Result:
//11
