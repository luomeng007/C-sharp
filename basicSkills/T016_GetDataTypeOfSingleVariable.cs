/*
Description:
    Aim: teach people how to get the type of single variable.
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // method one:
            int element = 5;
            // Method GetType() will return a type. So we need to save it by using a "type variable".
            Type type = element.GetType();
            // If we need to compare this type with another type, like int type. We need to compare it with "typeof(int)".
            if (type == typeof(int))
            {
                Console.WriteLine("Is the type of element int? {0}", "Yes");
            }

            // method two:
            // In order not to get warning message, here, we use keyword "object" when we do intialization.
            object element1 = 5;
            // use keyword "is" to judge the type of variable
            if (element1 is int)
            {
                Console.WriteLine("Is the type of element int? {0}", "Yes");
            }
        }
    }
}
