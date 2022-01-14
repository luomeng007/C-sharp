/*
Description:
    Aim: teach people how to use keyword "as".
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usage one: convert type
            // this method is not recommanded, we will get fixing tips for correction.        
            // create str1
            string str1 = "Xiao Ming";
            // assign str1 to obj1
            object obj1 = str1;
            // cast to(transfer) a string
            string str2 = obj1 as string;       
            // check
            if (str2 is string)
            {
                Console.WriteLine(str2);    //Xiao Ming
                Console.WriteLine(str2.GetType());  // System.String
            }
            // We have casted object type str2 to "System.String" type
        }
    }
}
