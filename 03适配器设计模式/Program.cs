using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03适配器设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------");
            {
                IHelper helper = new SqlserverHelper();
                helper.Add<Program>();
                helper.Delete<Program>();
                helper.Update<Program>();
                helper.Query<Program>();
            }
            Console.WriteLine("------------------------------------");
            {
                IHelper helper = new MySqlHelper();
                helper.Add<Program>();
                helper.Delete<Program>();
                helper.Update<Program>();
                helper.Query<Program>();
            }

            //继承  既满足现有的规范调用，又没有修改RedisHelper
            //类适配器模式
            Console.WriteLine("*************************************");
            {
                IHelper helper = new RedisHelperInherit();
                helper.Add<Program>();
                helper.Delete<Program>();
                helper.Update<Program>();
                helper.Query<Program>();
            }
            //组合 既满足现有的规范调用，又没有修改RedisHelper
            //对象适配器
            Console.WriteLine("*************************************");
            {
                IHelper helper = new RedisHelperObject();
                helper.Add<Program>();
                helper.Delete<Program>();
                helper.Update<Program>();
                helper.Query<Program>();
            }
            //A 上面说的组合优于继承的，具体分为以下两点来解释
            //1.侵入性：二者都会先构造一个redishelper,继承是强侵入的，父类的东西子类必须有
            //2.灵活性：继承只为一个类服务，结构可以为多个类型服务（属性注入，构造函数注入，方法注入  三种）
            //B:适配器主要是解决重构的问题，新东西和旧系统不吻合，通过继承/组合进行适配
            Console.ReadKey();
        }
    }
}
