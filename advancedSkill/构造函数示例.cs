/*
Description:
    Aim: teach people how to use constructor.
 */
using System;

namespace CSharp_Tutorial
{
    public class Program
    {
        class SampleClass
        {
            public int x;
            public int y;
            public const int c1 = 5;
            public const int c2 = c1 + 5;

            public SampleClass(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        }

        static void Main(string[] args)
        {
            SampleClass mC = new SampleClass(11, 22); // 创建一个全新的Sample Class 并给它一个名字
            Console.WriteLine("x = {0}, y = {1}", mC.x, mC.y);
            Console.WriteLine("c1 = {0}, c2 = {1}", SampleClass.c1, SampleClass.c2);
            // 也可以不给新创建的Sample class给名字，直接调用想要加入的参数
        }      
    }
}
