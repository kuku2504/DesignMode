using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04装饰器模式
{
    public class StudentPayDecoator : BaseStudentDecorator
    {
        public StudentPayDecoator(AbstractStudent student) : base(student)
        {

        }
        public override void Study()
        {
            base.Study();
            Console.WriteLine("付费");
        }
    }
}
