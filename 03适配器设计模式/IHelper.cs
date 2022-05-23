using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03适配器设计模式
{
    /// <summary>
    /// 数据访问接口
    /// </summary>
    public interface IHelper
    {
        void Add<T>();
        void Delete<T>();
        void Update<T>();
        void Query<T>();
    }
}
