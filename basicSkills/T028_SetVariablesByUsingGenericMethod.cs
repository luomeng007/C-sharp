/*
Description:
    Aim: teach people how to assign variables by using generic method.
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        // The first T represents that this method will return a generic type value
        // The second <T> represents SetGenericVariable method is generic method
        // The third T represents the input parameters for SetGenericVariable method is generic type
        public static T SetGenericVariable<T>(T value)
        {
            T a = value;
            return a;
        }

        static void Main(string[] args)
        {
            int a = SetGenericVariable<int>(1);
            Console.WriteLine(a);
        }
        // The function of above code is same as int a = 1.
        // However, if we have some algorithm inside it. Then using generic method is convenient. 
    }
}
