/*
Description:
    Aim: teach people how to create a generic array.
 */
using System;

namespace CSharp_Tutorial
{
    class CreateGenericArray<T>
    {
        private T[] array;
        public CreateGenericArray(int size)
        {
            array = new T[size];
        }
        public T getItem(int index)
        {
            return array[index];
        }
        public void setItem(int index, T value)
        {
            array[index] = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Initialize a int type array with five elements.
            CreateGenericArray<int> intArray = new CreateGenericArray<int>(5); 
            for (int c = 0; c < 5; c++)
            {
                intArray.setItem(c, c * 5);
            }
            for (int c = 0; c < 5; c++)
            {
                Console.Write(intArray.getItem(c) + " ");
            }

            Console.WriteLine();
            // Initialize a int char type array with five elements.
            CreateGenericArray<char> charArray = new CreateGenericArray<char>(5);
            // set value
            for (int c = 0; c < 5; c++)
            {
                charArray.setItem(c, (char)(c + 97));
            }
            // get value
            for (int c = 0; c < 5; c++)
            {
                Console.Write(charArray.getItem(c) + " ");
            }
            Console.WriteLine();
        }
    }
}
