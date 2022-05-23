using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05外观模式
{
    public class Computer
    {
        private CPU cpu;
        private Memory memory;
        private Disk disk;
        public Computer()
        {
            this.cpu = new CPU();
            this.memory = new Memory();
            this.disk = new Disk();
        }
        public void Start()
        {
            cpu.CUPStart();
            memory.MemoryStart();
            disk.DiskStart();
            Console.WriteLine("computer start end !");
        }
        public void Shutdown()
        {
            cpu.CPUShutdown();
            memory.MemoryShutdown();
            disk.DiskShutdown();
            Console.WriteLine("computer shutdown end!");
        }
    }
}
