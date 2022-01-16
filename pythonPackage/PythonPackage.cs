using System;
using System.Collections.Generic;

namespace PythonPackage
{
    public class Python
    {
        public static void Print<T>(IEnumerable<T> array)
        {
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
        }

        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6 };
            py.Print(list);
        }
    }
}
//result:
//1
//2
//3
//4
//5
//6
