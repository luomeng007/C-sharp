using System;
using System.Collections.Generic;
using System.Text;

namespace T_Constructor
{
    // 构造函数示例二
    class Car00
    {
        // 此时参数为public，可以从外部进行访问
        public string model;  // Create a field

        // Create a class constructor for the Car class
        // 参数具有初始值，可以直接打印
        public Car00()
        {
            model = "Mustang";
        }
    }
}
