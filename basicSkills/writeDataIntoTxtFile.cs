using System;
using System.IO;

namespace debug
{
    class Program
    {
        static void Main(string[] args)
        {
            // this could not be run directly. Need original data
            #region write data into .txt file
            string file_directory = @"C:\Users\15025\Desktop\final_data.txt";
            using StreamWriter file = new StreamWriter(file_directory);
            {
                count = 1;
                foreach (double line in final_array)
                {
                    file.Write(line.ToString() + "  ");
                    if (count % 34 == 0)
                    {
                        file.WriteLine();
                    }
                    count++;
                }
            }
            #endregion
        }
    }
}
