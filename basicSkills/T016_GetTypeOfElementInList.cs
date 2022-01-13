/*
Description:
    Aim: teach people how to get the type of list.
 */
using System;
using System.Collections.Generic;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method one：use GetType()
            // create a list object
            var list = new List<int>() { 1, 2 };
            Type type = list.GetType();
            if (type == typeof(List<int>))
            {
                Console.WriteLine("Is the type of list List<int>? {0}", "Yes");
            }

            // ================================================================================================================
            // Method two：use keyword "is"
            var list1 = new List<int>() { 1, 2 };
            if (list1 is List<int>)
            {
                Console.WriteLine("Is the type of list List<int>? {0}", "Yes");
            }
 
            // ================================================================================================================
            // Method three：use GetType() and GetGenericArguments()
            var list2 = new List<int>() { 1, 2 };
            Type[] type2 = list2.GetType().GetGenericArguments();
            if (type2[0] == typeof(int))
            {
                Console.WriteLine("Is the type of list List<int>? {0}", "Yes");
                Console.WriteLine("Is the type of element in list int? {0}", "Yes");
            }

            // ================================================================================================================
            // Method four: use GetType() and ToString()
            var list3 = new List<int>() { 1, 2 };
            foreach (var element in list3)
            {
                Type type3 = element.GetType();
                if (type3.ToString() == "System.Int32")
                {
                    Console.WriteLine("Is the type of element in list int? {0}", "Yes");
                }
            }

            // ================================================================================================================
            // Method five: use GetType() and Name
            var list4 = new List<int>() { 1, 2 };
            string type4 = list4[0].GetType().Name;
            Console.WriteLine(type4);
            if (type4 == "Int32")
            {
                Console.WriteLine("Is the type of element in list int? {0}", "Yes");
            }
        }
    }
}
