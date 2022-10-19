using System;
using System.Threading.Tasks;

namespace _84lock
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var account = new Account(1000);//初始值，设置为100

            //1.创建100个线程任务，去执行update操作
            var tasks = new Task[100];
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Run(() => Update(account));
            }
            await Task.WhenAll(tasks);//2.此处是等待完成任务，以上线程任务，完成之后，继续下面的逻辑代码



            //Update(account);
            Console.WriteLine($"Account's balance is {account.GetBalance()}");
            Console.ReadKey();
        }
        static void Update(Account account)
        {
            decimal[] amounts = { 0, 2, -3, 6, -2, -1, 8, -5, 11, -6 };
            foreach (var amount in amounts)
            {
                if (amount >= 0)
                {
                    account.Credit(amount);
                }
                else
                {
                    account.Debit(Math.Abs(amount));
                }
            }
        }
    }
}
