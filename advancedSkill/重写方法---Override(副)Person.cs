using System;
using System.Collections.Generic;
using System.Text;

namespace T_OverrideStringToString
{
    class Person
    {
        // 设定类的两个属性，Name和Age
        public string Name { get; set; }
        public int Age { get; set; }
        // 重写自带的ToString()方法来满足我们的要求
        // 并且仍旧返回string类型满足用户需求的数据
        // 使得Person类有了返回值
        public override string ToString()
        {
            return "Person: " + Name + " " + Age;
        }
    }
}
