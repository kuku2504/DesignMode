using System;

namespace _98base关键字用法
{
    public  class BaseClass
    {
        int num;
        public BaseClass()
        {
            Console.WriteLine("in BaseClass()");
        }
        public BaseClass(int i)
        {
            num = i;
            Console.WriteLine("in BaseClass(int i)");
        }
        public int GetNum()
        {
            return num;
        }
    }
}
