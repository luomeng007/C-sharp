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
                    int nextChar;

                    //nextChar = str1.Read();
                    
                    // if we use this as output, we will get 104, In ASCII, 104 correspond to char h
                    // Console.WriteLine(nextChar);
                    // so here we better use char to transfer this from int to char
                    // Console.WriteLine((char)nextChar);

                    // of course we could use a loop to print the content in this file at one time.
                    // in C # if could only follow bool type
                    // when no value, str1.Peek() will get integer value -1
                    // space is also a character
                    while (str1.Peek() != -1)
                    {
                        nextChar = str1.Read();
                        Console.Write((char)nextChar);
                    }
                    Console.WriteLine();
                }
            }
            # endregion
            
        }
    }
}
