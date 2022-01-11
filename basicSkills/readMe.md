list与array类型的数据自带GetEnumerator方法.  
default: 在泛型中被使用  
  给定参数化类型T的一个变量t，T为引用类型时，t=null,t为数值类型时t=0。对于泛型无法知道为什么具体的类型，如何将默认值分配给参数化类型T，此时创建变量就需要使用default。这个关键字对于引用类型就会返回null，对于数值类型就会返回0。  

存在的问题：system.Nullable(of T)的用法  
