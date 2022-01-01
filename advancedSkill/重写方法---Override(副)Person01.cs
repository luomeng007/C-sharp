using System;
using System.Collections.Generic;
using System.Text;

namespace T_OverrideStringToString
{
    class Person01
    {
        // 设定类的两个属性，name和age，对比Person类，这里不设定set get方法。
        public string name;
        public int age;
        // 重写自带的ToString()方法来满足我们的要求
        // 并且仍旧返回string类型满足用户需求的数据
        public override string ToString()
        {
            return "Person: " + name + " " + age;
        }
    }
}
