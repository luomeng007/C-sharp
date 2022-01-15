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
            // There are a lot of methods. Like Convert.ToSingle. Such as:
            //Byte.Parse();
            //Char.Parse();
            //Double.Parse();
            //Int16.Parse();
            //Int32.Parse();
            //Int64.Parse();
            //Boolean.Parse();
            //UInt16.Parse();
            //UInt32.Parse();
            //UInt64.Parse();
            // For string, we can use .ToString() method
        }
    }
}
