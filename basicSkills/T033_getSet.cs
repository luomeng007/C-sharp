/*
Description:
    Aim: teach people how to use get set methods in class.
 */
using System;

namespace CSharp_Tutorial
{
    #region example one
    //class Person
    //{
    //    private string name;
    //    public string Name
    //    {
    //        get { return name; }
    //        set { name = value; }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Person myObj = new Person();
    //        myObj.Name = "Liam";
    //        Console.WriteLine(myObj.Name);
    //    }
    //}
    #endregion

    #region example 2 less code
    class Person
    {

        public string Name   // property
        { get; set;}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);
        }
    }
    #endregion
}
//Result:
//Liam
