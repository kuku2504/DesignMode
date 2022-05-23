using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02代理模式
{
    /// <summary>
    /// 我们应用的时候不直接访问这个这个实际业务，
    /// 而是可以通过访问代理来实现这个业务，下面我们可以增加一个代理类
    /// </summary>
    public class ProxySubject : ISubject
    {
        //组合一下
        private static ISubject _subject = new RealSubject();
        public void DoSomething()
        {
            try
            {
                Console.WriteLine("prepare DoSomething...");
                _subject.DoSomething();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        private static Dictionary<string, bool> proxyDictionary = new Dictionary<string, bool>();
        public bool GetSomething()
        {
            try
            {
                Console.WriteLine("prepare GetSomething。。。");
                string key = "Proxy_GetSomething";
                bool bResult = false;
                if (!proxyDictionary.ContainsKey(key))
                {
                    bResult = _subject.GetSomething();
                    proxyDictionary.Add(key, bResult);
                }
                else
                {
                    bResult = proxyDictionary[key];
                }
                return bResult;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
