using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace twoThreadsAtATimeWithLoopLogic
{
    internal class Program
    {
        static void method1()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread1 : "+i);
            }
        }
        static void method2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread2 : " + i);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(method1);
            Thread t2 = new Thread(method2);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine("Both threads are finished");

        }
    }
}
