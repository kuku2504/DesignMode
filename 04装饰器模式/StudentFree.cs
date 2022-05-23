using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04装饰器模式
{
    public class StudentFree : AbstractStudent
    {
        public override void Study()
        {
            Console.WriteLine($"{base.Name} is a free student studying .net Free");
        }
    }
}
