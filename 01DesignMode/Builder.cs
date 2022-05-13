using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DesignMode
{
    /// <summary>
    /// 建造者抽象类，定义了建造者的能力
    /// </summary>
    public abstract class Builder
    {
        public abstract void DaDiJi();
        public abstract void QiZhuan();
        public abstract void FenShua();
    }
}
