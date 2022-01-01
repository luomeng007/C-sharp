using System;
using System.Collections;

namespace T_ArrayList
{
    public class Program
    {
        public static void Main()
        {

            // 相比于Array的用法，该方法创建的数组长度可以自增。
            // 创建一个ArrayList对象
            ArrayList myAL = new ArrayList();
            // 向其中添加一些元素，这里添加了三个字符串对象
            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add("!");

            // 进行显示
            // 打印创建好的ArrayList对象名称
            Console.WriteLine("myAL");
            // 打印ArrayList中字符串的个数，三个
            Console.WriteLine("    Count:    {0}", myAL.Count);
            // 打印ArrayList中的容量，这里为4
            // ArrayList.Capacity获取ArrayList中能够获取或存放的元素个数
            // 因为ArrayList长度是动态变化的，所以当我们添加了三个元素后
            // 它的列表长度自动增加1，变为4
            Console.WriteLine("    Capacity: {0}", myAL.Capacity);
            // 打印它的值
            Console.Write("    Values:");
            // 使用IEnumerable界面循环输出，需要学习！！！！！！！！！！！
            PrintValues(myAL);
        }

        // 
        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.Write("   {0}", obj);
            Console.WriteLine();
        }
    }
}
