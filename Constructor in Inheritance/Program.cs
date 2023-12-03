using System;

namespace Constructor_in_Inheritance
{
    class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("This is base Class Constructor");
        }
    }
    class DerivedClass: BaseClass
    {
        public DerivedClass() 
        {
            Console.WriteLine("This is Derived Class");
        }
    }


    class BaseClass1
    {
        //agar parametrized constructor hai to phir hamain derived class main isy parameter dena hoga
        public BaseClass1(string message)
        {
            Console.WriteLine(message);
        }

    }
    class DerivedClass1 : BaseClass1
    {
        public DerivedClass1():base("hello world")
        {
            Console.WriteLine("This is Derived Class");
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            //inheritance main dono ka constructor call ho ga.
            DerivedClass dr = new DerivedClass();

            Console.WriteLine("--------------------------");

            DerivedClass1 dr1 = new DerivedClass1();

            Console.ReadLine();
        }
    }
}
