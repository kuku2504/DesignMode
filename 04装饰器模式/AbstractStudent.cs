using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04装饰器模式
{
    public abstract class AbstractStudent
    {
        public int id { get; set; }
        public string Name { get; set; }
        public abstract void Study();
    }
}
