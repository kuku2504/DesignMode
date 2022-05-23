using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06桥接模式
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            _color.Paint("长方形");
        }
    }
}
