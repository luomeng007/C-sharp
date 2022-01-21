/*
Description:
    Aim: teach people how to use keyword "sizeof".
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("int 的大小是{0}", sizeof(int));
            Console.WriteLine("int 的大小是{0}", sizeof(short));
            Console.WriteLine("int 的大小是{0}", sizeof(double));
        }
    }
}
