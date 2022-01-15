/*
Description:
    Aim: teach people how to make a class inherit properties from another class.
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();

            Rect.SetWidth(5);
            Rect.SetHeight(7);

            // print total area of rectangle
            Console.WriteLine("The total area of rectangle is： {0}", Rect.GetArea());
        }
    }

    class Inherit
    {
        // Here, out variables are protected, so we cannot access it from outside directly. So we need to set some method to access these protected method.
        // As we see "SetWidt" and "SetHeight: method below.
        protected int width;
        protected int height;
        public void SetWidth(int w)
        {
            width = w;
        }
        public void SetHeight(int h)
        {
            height = h;
        }
    }
    
    class Rectangle : Inherit
    {
        public int GetArea()
        {
            return (width * height);
        }
    }
}
