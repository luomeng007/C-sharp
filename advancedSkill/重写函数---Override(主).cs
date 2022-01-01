using System;

namespace T_OverrideStringToString
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 示例一，Person类调用
            // Person p = new Person { Name = "Luo Meng", Age = 26 };
            // 上述代码与下面的代码等效
            //Person p = new Person();
            //p.Name = "Luo Meng";
            //p.Age = 26;
            //Console.WriteLine(p);
            #endregion

            #region 示例二，Person01类调用
            Person01 p = new Person01 { name = "Luo Meng", age = 26 };
            // 上述代码与下面的代码等效
            //Person01 p = new Person01();
            //p.name = "Luo Meng";
            //p.age = 26;
            Console.WriteLine(p);
            // 无论person类中设定字段的set，get方法与否，这里都可以使用类似于属性的调用方式
            // 对Person类中的字段进行赋值操作
            #endregion
        }
    }
}
/*
 * 与python一样，C#中的所有的类和结构体都是从Object类中继承的，因此所有的C#中的object
 * 都拥有ToString()方法。
 * 但是当我们创建自定义类或结构时，应重写ToString方法，以便将有关类型的信息提供给客户端代码。
 */
