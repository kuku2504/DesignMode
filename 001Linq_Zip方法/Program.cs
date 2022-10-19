using System;
using System.Linq;

namespace _001Linq_Zip方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组
            int[] intArray = { 1, 2, 3, 5, 6 };
            string[] stringArray = { "A", "B", "C", "D", "E", "F" };
            var mergedSed = intArray.AsQueryable().Zip(stringArray, (one, two) => one + "_" + two);
            foreach (var item in mergedSed)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
