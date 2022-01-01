using System;
using System.Collections.Generic;
using System.Text;

namespace T_Constructor
{
    // 构造函数
    // 构造函数是一种方法，其名称与其类型的名称相同。 
    // 其方法签名仅包含方法名称和其参数列表；它不包含返回类型。 
    // 以下示例演示一个名为 Person 的类的构造函数。
    // 示例一：
    public class Person
    {
        // 当为private的时候无法直接进行访问，需要更改为public类型
        //private string last;
        //private string first;
        public string last;
        public string first;

        public Person(string lastName, string firstName)
        {
            last = lastName;
            first = firstName;
        }

        // Remaining implementation of Person class.
    }
}
