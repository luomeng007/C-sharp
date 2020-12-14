using System;
using System.Collections.Generic;

namespace debug
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(1, "C#");
            myDictionary.Add(2, "C++");
            myDictionary.Add(3, "ASP.NET");
            myDictionary.Add(4, "MVC");
            // 字典是否含有为1的键值对象，有，则输出1的键值对
            if (myDictionary.ContainsKey(1))
            {
                //"1"对应的是这里的键值
                Console.WriteLine("Key:{0},Value:{1}", "1", myDictionary[1]);
                // 一样的
                Console.WriteLine("Key:{0},Value:{1}", 1, myDictionary[1]);
            }
            // 通过键值对遍历字典
            foreach (KeyValuePair<int, string> kvp in myDictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
            // 仅遍历字典的key值
            Dictionary<int, string>.KeyCollection keyCol = myDictionary.Keys;
            foreach (int key in keyCol)
            {
                Console.WriteLine("Key = {0}", key);
            }
            // 删除键值为1的字典
            myDictionary.Remove(1);
            // 这时字典中没有这个值了，我们再次打印的时候就会执行else语句的内容
            if (myDictionary.ContainsKey(1))
            {
                Console.WriteLine("Key:{0},Value:{1}", "1", myDictionary[1]);
            }
            else
            {
                Console.WriteLine("不存在 Key : 1");
            }
        }    
    }
}
//Result:
//Key: 1,Value: C#
//Key = 1, Value = C#
//Key = 2, Value = C++
//Key = 3, Value = ASP.NET
//Key = 4, Value = MVC
//Key = 1
//Key = 2
//Key = 3
//Key = 4
//不存在 Key : 1
