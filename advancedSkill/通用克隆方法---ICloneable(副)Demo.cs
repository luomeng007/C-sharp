using System;
using System.Collections.Generic;
using System.Text;

namespace T_ICloneable
{
    // 创建一个Demo类，继承ICloneable界面
    class Demo : ICloneable
    {
        // 初始化两个变量a,b
        public int a, b;
        // 构造函数
        public Demo(int x, int y)
        {
            a = x;
            b = y;
        }
        // 重写ToString()方法，使其满足我们的使用需求
        public override string ToString()
        {
            // 创建该类的时候就会被触发
            return string.Format(" a : " + a + "  b: " + b);
        }

        // 使用Icloneable界面复制时的特定写法
        public object Clone()
        {
            // 创建一个Demo对象d，其中有两个参数，然后返回d
            Demo d = new Demo(a, b);
            return d;
        }
    }
}
