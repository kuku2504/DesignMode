using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04装饰器模式
{
    public class StudentVideoDecorator : BaseStudentDecorator
    {
        public StudentVideoDecorator(AbstractStudent student) : base(student)//表示父类的构造函数
        {

        }
        public override void Study()
        {
            base.Study();
            Console.WriteLine("视频代码回看");
        }
    }
}
