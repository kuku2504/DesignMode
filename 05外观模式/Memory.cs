using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05外观模式
{
    public class Memory
    {
        public void MemoryStart()
        {
            Console.WriteLine(" Memory is Start...");
        }
        public void MemoryShutdown()
        {
            Console.WriteLine("Memory is Shut down......");
        }
    }
}
