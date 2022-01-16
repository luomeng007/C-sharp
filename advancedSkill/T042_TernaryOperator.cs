/*
Description:
    Aim: teach people how to use ternary operator.
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 10;
            b = (a == 1) ? 20 : 30;
            Console.WriteLine("b 的值是 {0}", b);
            // if a == 1, then assign variable with value 20, otherwise with value 30, so we get 30 here

            b = (a == 10) ? 20 : 30;
            Console.WriteLine("b 的值是 {0}", b);
            // if a == 10, then assign variable with value 20, otherwise with value 30, so we get 30 here

            // Example
            string str4 = "Xiao Ming";   // create str1
                                         // assign str1 to obj1
            object obj4 = str4;
            string str5;
            str5 = (string)((obj4 is string) ? obj4 : null);
            // if the type of obj4 is sting type, then we assign str5 with value obj4, otherwise, we assign str5 with value null
            // We can also write as below, however, sentence below is not recommended.
            //_ = (obj4 is string) ? str5 = (string)obj4 : str5 = null; 

            if (str5 is string) // check whether str5 is string type
            {
                Console.WriteLine("Successfully cast");
            }
        }
    }
}
