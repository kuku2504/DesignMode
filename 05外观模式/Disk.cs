using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05外观模式
{
    public class Disk
    {
        public void DiskStart()
        {
            Console.WriteLine("Disk is Start...");
        }
        public void DiskShutdown()
        {
            Console.WriteLine("Disk is Shut down......");
        }
    }
}
