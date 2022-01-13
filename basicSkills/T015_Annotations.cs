/*
Description:
    Aim: teach people how to write annotations in C#.
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // method 1: single line annotation
            // we need to use sign "//" at the beginning of lines. And then write annotation information after that sign.  
            // For example: this a the annotation of c#

            // method 2: multi-lines annotation
            /*
             this is another anotation of c #
             */
            // method 3: this kind of annotation will be displayed.
            // this a also the annotation of c#
            // if we want to write a function for ourself, like below,  a function for add two integer numbers. 
            // we can use this kind of method to write annotations. Once we put our mouse on the word "Add" below. The annotation we wrote will be 
            // displayed as tips. Which is "This is a function for adding two integer numbers".
            int a = 5;
            int b = 6;
            int c;
            c = Annotations.Add(a , b);
        }

    }

    class Annotations
    {
        /// <summary>
        /// This is a function for adding two integer numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }
    }
}
