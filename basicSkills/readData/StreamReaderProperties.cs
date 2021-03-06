using System;
using System.IO;
using System.Text;

namespace readData
{
    class Program
    {
        #region three properties
        static void Main(string[] args)
        {

            string path = @"C:\Users\15025\Desktop\C#Debug\debug.txt";
            if (File.Exists(path))
            {
                using StreamReader str1 = new StreamReader(path, Encoding.ASCII);
                {
                    // 属性与方法调用的不同是属性调用末尾无需括号，而方法调用需要括号
                    // return the encoding method
                    Console.WriteLine(str1.CurrentEncoding);
                    // return the underlying stream, if we read file, it should be filestream
                    Console.WriteLine(str1.BaseStream);
                    // check whether the current stream positon is at the end of the steam. return True or False value
                    Console.WriteLine(str1.EndOfStream);
                }
            }  
        }
        #endregion
    }
}
