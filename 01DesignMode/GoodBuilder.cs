using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DesignMode
{
    /// <summary>
    /// 技术好的建造者
    /// </summary>
    public class GoodBuilder : Builder
    {
        private StringBuilder house = new StringBuilder();
        public override void DaDiJi()
        {
            house.Append("深地基-->");
        }

        public override void FenShua()
        {
            house.Append("粉刷光滑-->");
        }

        public override void QiZhuan()
        {
            house.Append("砌砖整齐-->");
        }
        public string GetHouse()
        {
            return house.Append("好质量房子建成了！").ToString();
        }
    }
}
