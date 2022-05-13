using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DesignMode
{
    /// <summary>
    /// 技术坏的建造者
    /// </summary>
    public class BadBuilder : Builder
    {
        private StringBuilder house = new StringBuilder();
        public override void DaDiJi()
        {
            house.Append("浅挖地基-->");
        }

        public override void FenShua()
        {
            house.Append("粉刷粗糙-->");
        }

        public override void QiZhuan()
        {
            house.Append("砌砖错乱-->");
        }
        public string GetHouse()
        {
            return house.Append("坏质量房子建成了！").ToString();
        }
    }
}
