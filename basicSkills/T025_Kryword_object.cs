/*
Description:
    Aim: teach people the basic class object of c sharp.
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj1 = new object();
            Console.WriteLine(obj1.GetType());  // Type: System.Object

            // If we assign a double type value to an object type variable like obj1. The type of obj1 
            // will be converted to System.Double
            double d = 1.0;
            obj1 = d;
            Console.WriteLine(obj1.GetType());  // Type: System.Double
            // Actually. we assign any types like string, char, float, double type to object type. The object type will automatically changed into these types.

            // However, if we assign a integer type value a1 to an double type variable like d1. The type of d1
            // will still be System.Double. 
            int a1 = 1;
            double d1;
            d1 = a1;
            Console.WriteLine(d1.GetType());  // Type: System.Double
            // Same situation, if we assign a float type value f1 to an double type variable like d2. The type of d2
            // will still be System.Double. 
            float f1 = 1.0f;
            double d2;
            d2 = f1;
            Console.WriteLine(d2.GetType());  // Type: System.Double
            // However, we cannot assign string type to integer or float or double type.
            // An error will arise.
        }
    }
}
