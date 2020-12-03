namespace readData
{
    class Program
    {
        static void Main(string[] args)
        {
            // info will store the full directory we give
            DirectoryInfo info = new DirectoryInfo(@"C:\documents\C#Project\Pro_W\researchData\downloadFile\releasedFile\");
            // Exists method will get a bool value, if directory exits, True. Attention, judge directory not file.
            Console.WriteLine(info.Exists);
            
            
        }
    }
}
