/*
Description:
    Aim: teach people how to define a generic class.
 */


using System;

namespace CSharp_Tutorial
{
    class MyList<T>
    {
        // Console.WriteLine can only appear in a method
        public void print(T count)
        {
            Console.WriteLine(count);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> mList = new MyList<int>();
            mList.print(1);
        }
    }
}
