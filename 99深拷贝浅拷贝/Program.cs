using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99深拷贝浅拷贝
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawBase rect = new DrawBase();
            Console.WriteLine(rect.name);
            DrawBase line = rect.Clone() as DrawBase;
            line.name = "new";
            line.listName.Add("123");
            Console.WriteLine(rect.name);
            Console.WriteLine(rect.listName.Count);
            Console.ReadLine();
        }
    }
}
