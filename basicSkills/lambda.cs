using System;

// 匿名函数的使用方法，lambda函数更为方便
namespace debug
{
    class Program
    {
        delegate int Mydel(int x);
        static void Main()
        {
            
            Mydel del = x => x + 1;
            Console.WriteLine($"{del(10)}");
        }
        
    }
}
//Result:
//11
