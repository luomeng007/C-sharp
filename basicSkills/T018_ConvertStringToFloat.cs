/*
Description:
    Aim: teach people how to convert string type to float(single) type.
 */
using System;
using System.Globalization;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Why we need to use this package(library)(namespace)?
            // we use CultureInfo.InvariantCulture because in some culture, like German, comma will be regarded as a decimal rather that point
            // the CultureInfo belongs to System.Globalization namespace
            // method 1: parse method
            string s = "10.5";  // define a string
            float x = Single.Parse(s, CultureInfo.InvariantCulture);
            Console.WriteLine(x.GetType());

            // method 2: Convert method
            string s1 = "10.5";
            float x1 = Convert.ToSingle(s1, CultureInfo.InvariantCulture);
            Console.WriteLine(x1.GetType());
        }
    }
}
