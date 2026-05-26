using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace multithreading
{
    internal class CheckingIsBackground
    {
        public static void method()
        {
            for (int i = 1; i <= 10; i++)
            {
              Console.WriteLine("Background thread :"+i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Thread th=new Thread(method);
            th.IsBackground = true;
            th.Start();
            Console.WriteLine("thread is starting....");
            Thread.Sleep(2000);
            Console.WriteLine("Thread finished");

        }
    }
}
