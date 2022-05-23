using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03适配器设计模式
{
    /// <summary>
    /// 第三方提供
    /// 不能进行修改
    /// </summary>
    public class RedisHelper
    {
        public RedisHelper()
        {
            Console.WriteLine("构造RedisHelper");
        }
        public void AddRedis<T>()
        {
            Console.WriteLine("This is{0} Add", this.GetType().Name);
        }

        public void DeleteRedis<T>()
        {
            Console.WriteLine("This is{0} Delete", this.GetType().Name);
        }

        public void QueryRedis<T>()
        {
            Console.WriteLine("This is{0} Query", this.GetType().Name);
        }

        public void UpdateRedis<T>()
        {
            Console.WriteLine("This is{0} Update", this.GetType().Name);
        }
    }
}
