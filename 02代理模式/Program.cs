using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02代理模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************Proxy*************");
            ISubject subject = new ProxySubject();
            subject.GetSomething();
            subject.DoSomething();
            Console.ReadKey();
        }
    }
    //然后写到这里会有很多人，为啥不直接调用真实的业务类，而非得要使用代理调用呢？这个问题我们接下来来讨论一下：
    //比如我们买火车票，我们可以直接去火车站买火车票，但是如果火车站离我们住的地方比较远，过去不方便，然后周围又有代售点，
    //那我们是不是多一种选择，既可以去火车站又可以直接去代售点买呢，其实我们写代理类也类似于这个道理，
    //有时候我们需要增加一些自己的需求，比如增加个日志，增加个异常处理，然后又想提升一下性能，
    //这些完全都可以再ProxySubject中做，而不需要去修改实际业务类。
    //通过代理，能够为对象扩展功能(不是增加业务)而不去修改原始业务类，也就是包了一层，这就是代理要做的事情！
}
