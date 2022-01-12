/*
Description:
    Aim: teach people how to return value from customized function by using keyword "out".

    use keyword "out" on multiple 1D array.
 */
using System;

namespace CSharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1D_1 = new int[] { 1, 2 };
            var array1D_2 = new int[] { 3, 4 };
            // Here, we do not need to initialize array1D_sum and array1D_minus in advance
            // AddAndMinus(array1D_1, array1D_2, out int[] array1D_sum, out int[] array1D_minus);
            // another form:
            int[] array1D_sum;
            int[] array1D_minus;
            AddAndMinus(array1D_1, array1D_2, out array1D_sum, out array1D_minus);

            Console.WriteLine("The value of sum of array1D_1 and array1D_2 is: ");
            for (int i = 0; i < array1D_sum.Length; i++)
            {
                Console.WriteLine(array1D_sum[i]);
            }
            
            Console.WriteLine("The value of array1D_1 minus array1D_2 is: ");
            for (int i = 0; i < array1D_minus.Length; i++)
            {
                Console.WriteLine(array1D_minus[i]);
            }
        }

        public static void AddAndMinus(int[] array_1, int[] array_2, out int[] array_sum, out int[] array_minus)
        {
            array_sum = new int[array_1.Length];
            array_minus = new int[array_1.Length];
            for (int i = 0; i < array_1.Length; i++)
            {
                array_sum[i] = array_1[i] + array_2[i];
                array_minus[i] = array_1[i] - array_2[i];
            }
        }
    }
}
