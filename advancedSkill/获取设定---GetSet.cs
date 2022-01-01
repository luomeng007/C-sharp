using System;
using System.Collections.Generic;
using System.Text;

namespace T_getSet
{
    class Person
    {
        // 这里的name在C sharp中叫做字段(field)，为一种与对象或者类关联的变量成员
        // 类比于python，我们可以称其为类的一个属性
        // 私有方法，无法直接访问
        private string name;
        // 这里类似将Name与name关联了起来
        // 外部可以通过更改Name的值来进行访问name
        public string Name
        {
            // get方法
            get
            {
                return name;
            }
            // set方法
            set
            {
                name = value;   // 这里的value值该怎么进一步的理解？
            }
        }
    }
}
/*
 * 私有化类的属性（成员变量），通过外部进行间接而非直接访问的意义：
 * 定义private变量是为了防止该变量在类外部被随意修改，通过接口的形式可以是该变量被安全的访问
 * 可以只设定访问方法，而不设定更改方法
 */
