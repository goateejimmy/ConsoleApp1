using System;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Task asy = Asyncmytask();
            //await asy;

            //Console.WriteLine("End");


            Console.WriteLine("Hello World!");
            Task T = Task.Run(() => mytask());
            mytask();


            Console.WriteLine("End");
        }
        public static async Task Asyncmytask()
        {
            await bigfunc();
        }

        public static Task bigfunc()
        {
            return Task.Run(async () =>
            {
                int i = 0;
                while (i < 1000)
                {
                    Console.WriteLine($"Initiate the Main program in thread: {Thread.CurrentThread.ManagedThreadId}");
                    await Task.Delay(100); // 等待一小段時間，讓其他工作有機會執行
                    i++;
                }
            });
        }

        public static void mytask()
        {
            int i = 0;
            while (i < 1000)
            {
                Console.WriteLine("Intiate the Main program in thread : {0} ", Thread.CurrentThread.ManagedThreadId);
                i++;           
            }
        }
    }
}
