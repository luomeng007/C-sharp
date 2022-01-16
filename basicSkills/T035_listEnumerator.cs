/*
Description:
    Aim: teach people how to use listEnumerator method.
 */
using System;
using System.Collections.Generic;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mList = new List<int>();
            mList.Add(25);
            mList.Add(35);

            IEnumerator<int> rator = mList.GetEnumerator();
            Console.WriteLine($"Each element in mlist is:");
            while (rator.MoveNext())
            {
                Console.Write($"{rator.Current} ");
            }
            Console.WriteLine();
        }
    }
}
//Each element in mlist is:
//25 35
