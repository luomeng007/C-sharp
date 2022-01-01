using System;
using System.Collections.Generic;
using System.Text;

namespace T_Constructor
{
    class Product
    {
        // 相比于float，decimal具有更高的精度罢了
        public decimal Price;
        public int Year;

        public Product(decimal price)
        {
            Price = price;
        }
        // this (price)意思为调用price的构造函数
        // 当一个构造函数调用另一个时，被调用的构造函数会优先被执行
        // 这里包含year的构造函数调用price的构造函数，仅包含price的构造函数会优先被执行，
        // 然后这个包含year的构造函数后被执行，注意冒号和this的用法。
        public Product(decimal price, int year) : this (price)
        {
            Year = year;
        }
    }
}
