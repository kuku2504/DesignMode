using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06桥接模式
{
    public class Red : IColor
    {
        public void Paint(string shape)
        {
            Console.WriteLine($"红色的{shape}");
        }
    }
}
