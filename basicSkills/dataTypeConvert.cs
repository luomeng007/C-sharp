using System;

// two kinds of method of converting type of data
namespace basicUsage
{
    class dataTypeConvert
    {
        static void Main(string[] args)
        {
            // method 1: parse method
            string a = "10.55";

            float b = Single.Parse(a);

            Console.WriteLine(b);

            // method 2: Convert method
            string c = "47174.73";
            
            float d = Convert.ToSingle(c);
            
            Console.WriteLine(d);
        }
    }
}

/*
Attention:
    but when the system of computer is not English, it may raise some problem, because in current "locale", 
    the computer may not consider dot as decimal. So it may leave out dot. 
    Then we may get a wrong result. 
*/
