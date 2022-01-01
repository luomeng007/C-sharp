using System;

namespace T_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // 前三个均为实例化构造函数
            # region 示例一，Person类调用
            //string firstName = "Meng";
            //string lastName = "Luo";
            //Person p = new Person(lastName, firstName);
            //// c sharp 格式化输出方法记得总结，写个博客吧
            //Console.WriteLine(p.first +" "+ p.last);
            # endregion

            # region 示例二代码实现
            // 创建一个Car00类的对象，此时会调用构造函数
            // 也就是说构造函数在对应的类被创建的时候就会被调用，类似python中的__init__方法！
            //Car00 Ford = new Car00();
            //// 在屏幕上打印Car00类中的属性为Public的参数model的值
            //Console.WriteLine(Ford.model);
            # endregion

            # region 示例三代码实现
            //Car01 Ford = new Car01("Chang Cheng");
            //Console.WriteLine(Ford.model);
            # endregion

            // 重载构造函数
            # region 示例四代码实现
            // 注意c sharp中m对应decimal数据
            // 调用第一个构造函数
            //Product p = new Product(2.8m);
            //Console.WriteLine(p.Price);

            // 调用第二个构造函数
            // 如果这里不对Year进行赋值操作，则相当于调用了第一个构造函数，此时Year存放默认值0
            Product p = new Product(2.8m, 1988);
            Console.WriteLine(p.Price);
            Console.WriteLine(p.Year);
            # endregion
        }
    }
}
