using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04装饰器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractStudent student = new StudentVip()
            {
                id = 99,
                Name = "小白"
            };
            //BaseStudentDecorator decorator = new BaseStudentDecorator(student);
            //AbstractStudent decorator1 = new BaseStudentDecorator(student);//里氏替换
            student.Study();
            student = new BaseStudentDecorator(student);
            student.Study();
            student = new StudentHomeworkDecorator(student);
            student.Study();
            student = new StudentVideoDecorator(student);
            student.Study();
            Console.ReadKey();
        }
    }
}
