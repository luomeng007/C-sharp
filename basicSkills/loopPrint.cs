using System;
using System.Collections.Generic;

namespace basicUsage
{
    public class loopPrint
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3 };

            Console.WriteLine("Method 1 to loop print element in array");
            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"A is {array[i]}");
            }

            Console.WriteLine("Method 2 to loop print element in array");
            foreach (var a in array)
            {
                Console.WriteLine($"A is {a}");

            }

            Console.WriteLine("Method 2 to loop print element in array");
            // create an enumerator contain array
            var enumerator = array.GetEnumerator();
            // if we could reach the next position of enumerator
            while(enumerator.MoveNext())
            {
                // print element in current position
                Console.WriteLine($"A is {enumerator.Current}");
            }
        }
    }
}
//result:
//Method 1 to loop print element in array
//A is 1
//A is 2
//A is 3
//Method 2 to loop print element in array
//A is 1
//A is 2
//A is 3
//Method 2 to loop print element in array
//A is 1
//A is 2
//A is 3
