using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06桥接模式
{
    public abstract class Shape
    {
        //形状内部包含了另外一个维度：color
        protected IColor _color;
        public void SetColor(IColor color)
        {
            _color = color;
        }
        //设置形状
        public abstract void Draw();
    }
}
