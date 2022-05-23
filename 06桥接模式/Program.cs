using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06桥接模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle();
            IColor blue = new Blue();
            circle.SetColor(blue);//设置颜色
            circle.Draw();//画图

            Shape triangle = new Triangle();
            triangle.SetColor(blue);
            triangle.Draw();

            Shape circle1 = new Circle();
            IColor yellow = new Yellow();
            circle1.SetColor(yellow);
            circle1.Draw();
            Console.ReadKey();
            //桥接模式的使用场景：
            //当系统实现有多个角度分类，每种分类都可能变化时使用
            //近几年提出的微服务概念采用了桥接模式的思想，通过各种服务的组合来实现一个大的系统

            //桥接模式的优点：
            //1.实现抽象和具体的分离，降低了各个分类角度间的耦合
            //2.扩展性好，解决了多角度分类使用继承可能出现的子类爆炸问题

            //桥接模式的缺点：
            //桥接模式的引进需要通过聚合关联关系建立抽象层，增加了理解和设计系统的难度
        }
    }
}
