using System;
using System.Collections.Generic;
using System.Text;

namespace T_ICloneable
{
    class Person
    {
        public int Age { get; set; }
        // 这里的Person表示Father的返回值为Person类的类型
        // 这里并不是构造函数，Father是Person类的一个属性
        public Person Father 
        {   
            get
            {
                return this;
            }
            set
            {

            }
        }
        public Person Mother 
        {
            get
            {
                return this;
            }
            set
            {

            }
        }

        public object Clone()
        {
            // 返回原始的Person类
            return this;
        }
    }
}

