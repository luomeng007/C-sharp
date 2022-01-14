/*
Description:
    Aim: teach people how to use keyword "public" in functions. 
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Package r = new Package();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
    }

    class Package
    {
        // Here, variables length and width are all public, so user can access them from outside directly. User do not need to define any other methods to access
        // these two variables
        public double length;
        public double width;
        
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
