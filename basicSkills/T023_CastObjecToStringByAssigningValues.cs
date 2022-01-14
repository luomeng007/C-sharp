/*
Description:
    Aim: teach people how to cast type object to type string by directly assigning values.
    
    Later we will talk about keyword "object" in detail.
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usage two:
            string str1 = "Xiao Ming";  // create str3           
            object obj1 = str1; // assign str1 to obj1  
            // onject is a base class, so if we assign it with type string, it will be type string. 
            
            // cast to(transfer) a string
            // check
            if (obj1 is string)
            {
                Console.WriteLine(obj1);
                Console.WriteLine(obj1.GetType());
            }
        }
    }
}
