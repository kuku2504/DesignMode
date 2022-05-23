using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03适配器设计模式
{
    public class RedisHelperObject : IHelper
    {
        public RedisHelperObject()
        {
            Console.WriteLine($"构造{this.GetType().Name}");
        }
        //属性注入  声明写死
        private RedisHelper _redisHelper = new RedisHelper();
        /// <summary>
        /// 构造函数，可以替换（抽象需要）
        /// </summary>
        /// <param name="redisHelper"></param>
        public RedisHelperObject(RedisHelper redisHelper)
        {
            this._redisHelper = redisHelper;
        }
        //方法注入  可以替换（需要抽象）
        public void SteObject(RedisHelper redisHelper)
        {
            this._redisHelper = redisHelper;
        }
        public void Add<T>()
        {
            this._redisHelper.AddRedis<T>();
        }

        public void Delete<T>()
        {
            this._redisHelper.DeleteRedis<T>();
        }

        public void Query<T>()
        {
            this._redisHelper.DeleteRedis<T>();
        }

        public void Update<T>()
        {
            this._redisHelper.UpdateRedis<T>();
        }
    }
}
