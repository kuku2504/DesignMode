using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04装饰器模式
{
    public class BaseStudentDecorator : AbstractStudent
    {
        private AbstractStudent _student = null;//用了组合加override
        public BaseStudentDecorator(AbstractStudent student)
        {
            _student = student;
        }
        public override void Study()
        {
            _student.Study();
        }
    }
}
