using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DesignMode
{
    /// <summary>
    /// 监工类，指定盖房子的步骤
    /// </summary>
    public class Director
    {
        private Builder _builder;
        public Director(Builder builder)
        {
            _builder = builder;
        }
        //指定盖房子的流程
        public void Construct()
        {
            _builder.DaDiJi();
            _builder.QiZhuan();
            _builder.FenShua();
        }
    }

}
