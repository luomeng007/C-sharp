﻿using System;
using System.Globalization;

// convert type of data, when our system is using German.
namespace basicUsage
{
    class dataTypeConvert01
    {
        static void Main(string[] args)
        {
            // method 1: parse method
            string a = "10.55";

            float b = Single.Parse(a, CultureInfo.InvariantCulture);

            Console.WriteLine(b);

            // method 2: Convert method
            string c = "47174.73";
            
            float d = Convert.ToSingle(c, CultureInfo.InvariantCulture);
            
            Console.WriteLine(d);
        }
    }
}
/*
this method is not good enough to do so, we need to illustate this more in detail.
*/
