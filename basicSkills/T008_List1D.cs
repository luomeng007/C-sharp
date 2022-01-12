/*
Description:
    Aim: teach people how to generate 1D list

    List method belongs to "System.Collections.Generic" package, we need to add this package at the beginning of our code
 */
using System;
using System.Collections.Generic;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // method 1:
            List<int> list1D = new List<int>(); // initialize a 1D list without specifying length, this list theoretically can contain infinite elements
            // However, we do not recommend this method, because it will take a lot of computer memory(RAM) and sacrifice running speed of program.
            // RAM: Random Access Memory
            // method 2:
            List<int> list1D_1 = new List<int>(2); // initialize a 1D list with specifying length
            //However, this list theoretically can also contain infinite elements even we set its length as 2 at initialization.
            // Like below, we can add three elements into it.
            list1D_1.Add(1);
            list1D_1.Add(2);
            list1D_1.Add(3);
            Console.WriteLine("The elements in list1D_1 are: ");
            for (int i = 0; i < list1D_1.Count; i++)  // loop print all values in list1D_1
            {
                Console.WriteLine(list1D_1[i]);
            }
            // method 3:
            List<int> list1D_2 = new List<int> { 1, 2 };  // initialize a 1D list with specifying elements
            // method 4:
            List<int> list1D_3 = new List<int>(){ 1, 2 }; // initialize a 1D list with specifying elements
            // Compared with method 3, we add small brackets () here, this is official expression. Although the style in method 3 works, but I recommend the style in method 4.
            // This is a standard style.
            Console.WriteLine("The elements in list1D_3 are: ");
            for (int i = 0; i < list1D_3.Count; i++)  // loop print all values in list1D_3
            {
                Console.WriteLine(list1D_3[i]);
            }
        }
    }
}
