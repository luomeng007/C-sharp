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
            string s1 = "10.5";
            float x1 = Convert.ToSingle(s1, CultureInfo.InvariantCulture);
            Console.WriteLine(x1.GetType());
            // There are a lot of methods. Like Convert.ToSingle. Such as:
            //Convert.ToByte();
            //Convert.ToChar();
            //Convert.ToString();
            //Convert.ToDouble();
            //Convert.ToInt16();
            //Convert.ToInt32();
            //Convert.ToInt64();
            //Convert.ToBoolean();
            //Convert.ToUInt16();
            //Convert.ToUInt32();
            //Convert.ToUInt64();
        }
    }
}
