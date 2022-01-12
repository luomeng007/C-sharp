/*
Description:
    Aim: teach people how to compare two strings.
    
    string.Compare(a, b) or String.Compare(a, b)
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
            string s1 = "hello";
            string s2 = "hello";
            string s3 = "csharp";
            string s4 = "mello";

            Console.WriteLine(string.Compare(s1, s2));
            Console.WriteLine(string.Compare(s2, s3));
            Console.WriteLine(string.Compare(s3, s4));
        }
    }
}
