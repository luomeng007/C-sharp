using System;
using System.IO;

namespace readData
{
    class Program
    {
        static void Main(string[] args)
        {
            #region method1: use using method to open file. we could leave out close progress
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader. like with open in python
                using (StreamReader sr = new StreamReader(@"C:\documents\C#Project\Pro_W\researchData\downloadFile\releasedFile\rayfile_SPL_DS90A_3_100k_20200714_ASCII.TXT"))
                {
                    string nextline;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((nextline = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(nextline);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            #endregion
            
             #region method2: normal method to open file and read
             try
            {
                // Create an instance of StreamReader to read from a file.
                StreamReader sr = new StreamReader(@"C:\documents\C#Project\Pro_W\researchData\downloadFile\releasedFile\rayfile_SPL_DS90A_3_100k_20200714_ASCII.TXT");
                string nextline;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((nextline = sr.ReadLine()) != null)
                {
                    Console.WriteLine(nextline);
                }
                // better close steamReader object after use
                sr.Close();
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
             # endregion
            
        }
    }
}
