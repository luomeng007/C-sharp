using System;

namespace T_ICloneable
{
    class Program
    {
        #region 示例一，Car类调用
        //static void Main()
        //{
        //    // carOne 为object类型对象
        //    Car carOne = new Car(1695);
        //    // 所以我们这里必须使用(Car)对carOne的类型进行转换使其匹配
        //    Car carTwo = (Car)carOne.Clone();
        //    // 两种写法
        //    // c sharp中as与强制类型转换的区别：
        //    // 使用as如果出现问题会返回0值，对于object对象程序员进行判断方便，程序速度也快
        //    // 传统的类型转换方法速度较慢，而且如果遇到问题会直接抛出一个错误导致程序中断执行
        //    // 但是对于数值类型，如float, int, doule, decimal，应该使用传统的类型转换
        //    // 因为使用as失败时候的特征值0与它们会有冲突。
        //    //Car carTwo = carOne.Clone() as Car;
        //    Console.WriteLine("{0}mm", carOne);
        //    Console.WriteLine("{0}mm", carTwo);
        //    // 结果：最终通过复制，两个对象得到的值一致
        //}
        #endregion

        #region 示例二，Demo类调用
        //static void Main()
        //{   // 创建一个名称为d1的Demo类，且给予x,y参数值
        //    Demo d1 = new Demo(10, 20);
        //    Console.WriteLine(" d1 : " + d1);

        //    // 创建一个名称为d2的Demo类，该类调用Clone()方法复制d1
        //    Demo d2 = (Demo)d1.Clone();
        //    Console.WriteLine(" d2 : " + d2);

        //    // 创建一个名称为d3的Demo类，该类调用Clone()方法复制d2
        //    Demo d3 = (Demo)d2.Clone();
        //    Console.WriteLine(" d3 : " + d3);

        //    // 改变创建的d1类中的值并查看三个类中的结果
        //    Console.WriteLine("Changing the value of d1");

        //    d1.a = 44;
        //    d1.b = 33;


        //    Console.WriteLine(" d1 : " + d1);

        //    Console.WriteLine(" d2 : " + d2);

        //    Console.WriteLine(" d3 : " + d3);


        //    Console.WriteLine("Changing the value of d3");

        //    d3.a = 50;
        //    d3.b = 60;

        //    Console.WriteLine(" d1 : " + d1);

        //    Console.WriteLine(" d2 : " + d2);

        //    Console.WriteLine(" d3 : " + d3);


        //    Console.ReadKey();
        //}
        // 结果：无论改变d1还是d3类中的值，都只对它们自己产生作用，d2类中的数据不发生变化
        // 还是原来类定义时复制的原始d1类中的值
        #endregion

        #region 示例三，Person类调用
        // 这个示例的用法暂时不用详细了解
        static void Main()
        {
            // Father为Person类的属性，但是p.Father, p.Mother, p均还是为
            // ICloneable 类
            Person p = new Person { Age = 26 };
            p.Father = new Person { Age = 55 };
            p.Mother = new Person { Age = 51 };
            Console.WriteLine(p);
            Console.WriteLine(p.Father);
            Console.WriteLine(p.Mother);
        }
        #endregion
    }
}
/*
 * C sharp 中的深浅拷贝区别：
 * 浅拷贝表示，value的类型被拷贝，但是reference的类型不会被拷贝
 * ICloneable界面其实并没有什么意义，并不能够真正的实现浅拷贝或者深拷贝，因此不推荐使用
 * 
 */
