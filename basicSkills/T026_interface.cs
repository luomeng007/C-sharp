/*
Description:
    Aim: teach people how to write an interface.
 */
using System;

namespace CSharp_Tutorial
{
    // define an interface
    interface MyInterface
    {
        // default type is public
        // the member of interface
        public void Implement();
    }

    // set members of interface
    class SelfInterface : MyInterface
    {
        public void Implement()
        {
            Console.WriteLine("MethodToImplement() called.");
        }
    }
    class Program
    {
        // call interface
        static void Main(string[] args)
        {
            SelfInterface iImp = new SelfInterface();
            iImp.Implement();
        }
    }
}
