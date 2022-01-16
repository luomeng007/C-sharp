/*
Description:
    Aim: teach people basic calculations in c sharp.
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //int a = 21;
            //int b = 10;
            //int c;

            //c = a + b;                  // 输入的时候格式自动调整真的棒
            //Console.WriteLine("Line 1 - c 的值是 {0}", c);
            //c = a - b;
            //Console.WriteLine("Line 2 - c 的值是 {0}", c);
            //c = a * b;
            //Console.WriteLine("Line 3 - c 的值是 {0}", c);
            //c = a / b;
            //Console.WriteLine("Line 4 - c 的值是 {0}", c);
            //c = a % b;
            //Console.WriteLine("Line 5 - c 的值是 {0}", c);

            //// ++a先行自增运算再赋值
            //c = ++a;
            //Console.WriteLine("Line 6 - c 的值是 {0}", c);

            //// 此时a的值为22
            //// --a 先进行自减运算再赋值
            //c = --a;
            //Console.WriteLine("Line 7 - c 的值是 {0}", c);
            //Console.ReadLine();
            #endregion

            #region
            //int a = 1;
            //int b;

            //// a++先赋值再进行自增运算
            //b = a--;
            //Console.WriteLine("a = {0}", a);
            //Console.WriteLine("b = {0}", b);
            //Console.WriteLine();

            //// ++a先进性自增运算再赋值 
            //a = 1;
            //b = ++a;
            //Console.WriteLine("a = {0}", a);
            //Console.WriteLine("b = {0}", b);
            //Console.WriteLine();

            //// a-- 先赋值再进行自减运算
            //a = 1;  // 重新初始化 a
            //b = a--;
            //Console.WriteLine("a = {0}", a);
            //Console.WriteLine("b = {0}", b);
            //Console.WriteLine();

            //// --a 先进行自减运算再赋值
            //a = 1;  // 重新初始化 a
            //b = --a;
            //Console.WriteLine("a = {0}", a);
            //Console.WriteLine("b = {0}", b);
            //Console.WriteLine();
            #endregion

            #region
            //int a = 21;
            //int b = 10;

            //if (a == b)
            //{
            //    Console.WriteLine("Line 1 - a 等于 b");
            //}
            //else
            //{
            //    Console.WriteLine("Line 1 - a 不等于 b");
            //}
            //if (a < b)
            //{
            //    Console.WriteLine("Line 2 - a 小于 b");
            //}
            //else
            //{
            //    Console.WriteLine("Line 2 - a 不小于 b");
            //}
            //if (a > b)
            //{
            //    Console.WriteLine("Line 3 - a 大于 b");
            //}
            //else
            //{
            //    Console.WriteLine("Line 3 - a 不大于 b");
            //}
            ///* 改变a和b的值*/
            //a = 5;
            //b = 20;
            //if (a <= b)     // if 语句之后不应该出现冒号
            //{
            //    Console.WriteLine("Line 4 - a 小于或等于 b");
            //}
            //if (b >= a)
            //{
            //    Console.WriteLine("Line 5 - b 大于或等于 a");
            //}
            #endregion

            #region
            bool a = true;
            bool b = true;

            if (a && b)
            {
                Console.WriteLine("Line 1 - 条件为真");
            }
            if (a || b)
            {
                Console.WriteLine("Line 2 - 条件为真");
            }
            /* 改变 a 和 b 的值 */
            a = false;
            b = true;
            if (a && b)
            {
                Console.WriteLine("Line 3 - 条件为真");
            }
            else
            {
                Console.WriteLine("Line 3 - 条件不为真");
            }
            if (!(a && b))
            {
                Console.WriteLine("Line 4 - 条件为真");
            }
            Console.WriteLine();
            #endregion
        }
    }
}
