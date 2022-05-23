using System;

namespace _98base关键字用法
{
    public class Employee:Person
    {
        public string id = "ABCV3434";
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Employee ID{id}");
        }
    }
}
