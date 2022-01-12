/*
Description:
    Aim: teach people how to return value from customized function by using keyword "ref".
    
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
            var array1D_sum = new int[array1D_1.Length];
            var array1D_minus = new int[array1D_1.Length];
            AddAndMinus(array1D_1, array1D_2, ref array1D_sum, ref array1D_minus);

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

        public static void AddAndMinus(int[] array_1, int[] array_2, ref int[] array_sum, ref int[] array_minus)
        {
            for (int i = 0; i < array_1.Length; i++)
            {
                array_sum[i] = array_1[i] + array_2[i];
                array_minus[i] = array_1[i] - array_2[i];
            }
        }
    }
}
