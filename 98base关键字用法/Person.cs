using System;

namespace _98base关键字用法
{
    public class Person
    { 
        protected string ssn = "444-55-6666";
        protected string name = "John L. Malgraine";
        public virtual void GetInfo()
        {
            Console.WriteLine($"Name:{name}");
            Console.WriteLine($"SSN:{ssn}");
        }
    }
}
