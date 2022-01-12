/*
Description:
    Aim: teach people how to return value from customized function by using keyword "out".

    use keyword "out" on single array.
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static public void FillArray(out int[] myArray)
        {
            // Initialize the array:
            myArray = new int[5] { 1, 2, 3, 4, 5 }; // If we leave out this step here, an error arise
        }

        static public void Main()
        {
            int[] myArray; // Initialization is not required

            // Pass the array using out:
            FillArray(out myArray);

            // Display the array elements:
            Console.WriteLine("Array elements are:");
            for (int i = 0; i < myArray.Length; i++)
                Console.WriteLine(myArray[i]);
        }
    }
}
