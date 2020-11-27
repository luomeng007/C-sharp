using System;

namespace basicUsage
{
    public class Anotations
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3 };
            Console.WriteLine("Method 1 to print result---like f string");
            foreach (var a in array)
            {     
                Console.WriteLine($"A is {a}");
            }
            Console.WriteLine("Method 2 to print result---like format");
            foreach (var a in array)
            {
                Console.WriteLine("A is {0}", a);
            }
            Console.WriteLine("Method 3 to print result---like + method");
            foreach (var a in array)
            {
                Console.WriteLine("A is " + a.ToString());
            }
            Console.WriteLine("Method 4 to print result---like fomat method");
            // same as method 2, but String.Format keyword could be leaved out
            foreach (var a in array)
            {
                Console.WriteLine(String.Format("A is {0}", a));
            }
        }
    }
}
//Method 1 to print result---like f string
//A is 1
//A is 2
//A is 3
//Method 2 to print result---like format
//A is 1
//A is 2
//A is 3
//Method 3 to print result---like + method
//A is 1
//A is 2
//A is 3
//Method 4 to print result---like fomat method
//A is 1
//A is 2
//A is 3
