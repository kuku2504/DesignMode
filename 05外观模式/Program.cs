using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05外观模式
{
   /*外观模式也被叫做门面模式，这种模式的作用是：隐藏系统的复杂性，并向客户端提供了一个可以访问系统的统一接口，
    这个统一的接口组合了子系统的多个接口。使用统一的接口使得子系统更容易被访问或使用*/
  //子系统角色：实现了各种子功能，子系统之间可以相互交户，也可以提供给客户端直接调用的接口。
  //门面角色：熟悉子系统的功能，可以把子系统的功能组合在一起然后提供一个统一的接口供客户端调用。
  //客户端角色：调用Facede来实现要完成的功能
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.Start();
            Console.WriteLine("***********************");
            computer.Shutdown();
            Console.ReadKey();
        }
    }
    /*
外观模式的使用：
　　外观模式在我们的开发中使用的比较频繁，以三层架构为例：
　　子系统角色：Dal层，负责数据访问，比如有UserDal和RoleDal，UserDal返回的数据格式为[名字：张三，角色ID：3],RoleDal层返回的数据格式[角色ID:3,角色名：管理员]
　　 门面角色：Bll层，负责具体业务（汇总子系统的功能，这里使用UserDal和RoleDal两个子系统角色的功能），返回的数据格式[名字：张三 ，角色名：管理员]
　　客户端角色：UI层，通过Bll层直接拿到格式如[名字：张三 ，角色名：管理员]的数据。

外观模式的优点：
　　1.隐藏了系统的复杂性，让客户端使用系统功能时变很简单；
　　2.实现客户端和子系统间的解耦。

外观模式的缺点：
　　1.不符合开闭原则，如客户端要使用更多功能时，不仅仅在子系统进行添加或修改操作，也必须修改门面层。
     */
}
