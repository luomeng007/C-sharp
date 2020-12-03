using System;
using System.IO;
using System.Text;

namespace readData
{
    class Program
    {
        static void Main(string[] args)
        {
            #region method1: use using method to open file. we could leave out close progress
            string path = @"C:\Users\15025\Desktop\C#Debug\debug.txt";
            if (File.Exists(path))
            {
                using StreamReader str1 = new StreamReader(path, Encoding.ASCII);
                {
                    // read 3 characters at one time
                    int numChars = 3;

                    char[] charArray = new char[numChars];

                    // we will get h character here/
                    Console.WriteLine((char)str1.Peek());

                    // only return next available character
                    while (str1.Peek() != -1)
                    {
                        // the return value is a integer, represent the number of characters we read at current operation
                        int num = str1.Read(charArray, 0, numChars);

                        Console.WriteLine(charArray);

                        // in this file, we could only get two characters at last read. but we still get three, the compiler automtically
                        // add one. But we could see from the tip message below, num = 2
                        Console.WriteLine($"We have successfully read {num} characters at one time.");
                    }
                }
            }
            # endregion
            
        }
    }
}
