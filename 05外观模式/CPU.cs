using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05外观模式
{
    public class CPU
    {
        public void CUPStart()
        {
            Console.WriteLine("CPU is start...");
        }
        public void CPUShutdown()
        {
            Console.WriteLine("CPU is shut down.......");
        }
    }
}
