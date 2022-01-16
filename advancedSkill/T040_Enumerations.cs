/*
Description:
    Aim: teach people how to use enumerations.
 */
using System;

namespace CSharp_Tutorial
{
    // just like a list
    enum WeekDays
    {
        Monday = 0,
        Tuesday = 1,
        Wednesday = 2,
        Thursday = 3,
        Friday = 4,
        Saturday = 5,
        Sunday = 6
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WeekDays.Friday); // write Friday element
            // By default, the first item of an enum has the value 0. The second has the value 1, and so on.
            // To get the integer value from an item, you must explicitly convert the item to an int
            Console.WriteLine((int)WeekDays.Friday);
        }
    }
}
