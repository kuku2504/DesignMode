using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99深拷贝浅拷贝
{
    public class DrawBase : System.Object, ICloneable
    {
        public List<string> listName = new List<string>();
        public string name = "old";
        public DrawBase()
        {

        }
        /// <summary>
        /// 实现ICloneable 的接口
        /// 支持克隆，即用与现有实例相同的值创建类的新实例。
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            //输出 old new 1 说明：方法总是引用同一个对象，因此相应的堆内存上的值会改变
            //return this as object;//引用同一个对象

            //输出old old 1 对于内部的Class的对象和数组，会Copy地址一份。
            //[从而改变B时，A也被改变了]而对于其它内置的int/string/Enum/struct/object类型，则进行值copy

            //return this.MemberwiseClone();//浅复制
            //输出 old old 0 完全时创建一个新对象
            return new DrawBase() as object;//深复制
        }
    }
}
