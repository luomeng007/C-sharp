using System;
using System.Globalization;

// all kinds of c sharp anotations
namespace basicUsage
{
    class mainProgram
    {
        static void Main(string[] args)
        {
            // method 1: parse method
            string a = "10.55";

            float b = Single.Parse(a);

            Console.WriteLine(b);

            // method 2: Convert method
            string c = "47174.73";
            
            float d = Convert.ToSingle(c);
            
            Console.WriteLine(d);
        }
    }
}
