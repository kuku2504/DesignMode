using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DesignMode
{
    class Program
    {
        static void Main(string[] args)
        {
            GoodBuilder goodBuilder = new GoodBuilder();
            Director directorGood = new Director(goodBuilder);
            directorGood.Construct();
            string houseGood = goodBuilder.GetHouse();
            Console.WriteLine(houseGood);

            BadBuilder badBuilder = new BadBuilder();
            Director directorBad = new Director(badBuilder);
            directorBad.Construct();
            string houseBad = badBuilder.GetHouse();
            Console.WriteLine(houseBad);

            Console.ReadKey();
        }
    }
}
