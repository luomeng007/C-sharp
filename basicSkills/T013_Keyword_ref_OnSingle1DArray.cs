/*
Description:
    Aim: teach people how to return value from customized function by using keyword "ref".

    use keyword "ref" on single 1D array.
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static public void FillArray(ref int[] myArray)
        {
            // override the array:
            myArray = new int[5] { 1, 2, 3, 4, 5 }; // If we leave out this step here, no error arises, myArray will keep its original value
        }

        static public void Main()
        {
            int[] myArray = new int[] { 1 };

            // Pass the array using "ref":
            FillArray(ref myArray); // Initialization is required

            // Display the array elements:
            Console.WriteLine("Array elements are:");
            for (int i = 0; i < myArray.Length; i++)
                Console.WriteLine(myArray[i]);
        }
    }
}
