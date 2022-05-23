using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06桥接模式
{
    public class Triangle : Shape
    {
        public override void Draw()
        {
            _color.Paint("三角形");
        }
    }
}
