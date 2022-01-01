using System;
using System.Collections.Generic;
using System.Text;

namespace T_ICloneable
{
    // 定义一个car类，然后继承ICloneable界面
    class Car : ICloneable
    {
        // 定义变量宽度
        int width;

        // 构造函数
        public Car(int width)
        {
            // this相当于python的self指代的是Car这个类
            // 因此Car有一个宽度属性
            this.width = width;
        }

        // 复制函数,外部通过.Clone()进行调用
        public object Clone()
        {
            return new Car(this.width);
        }

        // 重写ToString()方法，返回一个我们需要的输出结果
        public override string ToString()
        {
            // 格式化输出的方法
            // this指代这个Car类，最后输出小汽车的width字段（属性）
            return string.Format("Width of car = {0}", this.width);
        }
    }
}
