/*
Description:
    Aim: teach people how to package functions.

    Use keyword "public", "private", "protected" and "internal" to set the user's access rights, and implement it through access modifiers.

    pubic member variables: can be access from outside directly.

    private member variables: even the instance of class cannot access it.Like the variables hide themselves. 
    If we want to packge thing, we should use "private" keyword

    protected member variables: Allows subclasses to access its member variables, generally used for inheritance（继承）
    internal member variables: Allows current program to access its member variables. However, other program cannot access.
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Package r = new Package();
            r.InputLengthAndWidthOfRectangle();
            r.Display();
            Console.ReadLine();
        }
    }

    class Package
    {
        private double length;
        private double width;
        // InputLengthAndWidthOfRectangle() is a method to set the value of private variables length and width.
        public void InputLengthAndWidthOfRectangle()
        {
            Console.WriteLine("Please input the lenght of rectangle： ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input the width of rectangle：");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("The length of rectangle is： {0}", length);
            Console.WriteLine("The width of rectangle is： {0}", width);
            Console.WriteLine("The area of rectangle is： {0}", GetArea());
        }
    }
}
