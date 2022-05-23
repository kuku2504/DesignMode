using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06桥接模式
{
    public class Blue : IColor
    {
        public void Paint(string shape)
        {
            Console.WriteLine($"蓝色的{shape}");
        }
    }
}
