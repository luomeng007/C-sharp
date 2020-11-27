using System;

class MyList<T>
{
    // class variables, all method could use, just as in python
    T[] arrays = new T[5];
    int count;

    // Console.WriteLine can only appear in a method
    public void print()
    {
        Console.WriteLine(count);

    }
}

class MainClass
{
    static void Main(string[] args)
    {
        MyList<int> mList = new MyList<int>();
        mList.print();
    }
}
