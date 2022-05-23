using System;

namespace _98base关键字用法
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.GetInfo();
            //
            DerivedClass md = new DerivedClass();
            DerivedClass md1 = new DerivedClass(98);
            Console.ReadKey();
        }
    }
}
