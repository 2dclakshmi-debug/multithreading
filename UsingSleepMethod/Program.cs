using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingSleepMethod
{
    internal class Program
    {
        static void method1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Thread1 : " + i);
                Thread.Sleep(2000);
            }
        }
        static void method2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Thread2 : " + i);
                Thread.Sleep(2000);
            }
        }
        static void method3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Thread3 : " + i);
            }
        }
        static void method4()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Thread4 : " + i);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(method1);
            Thread t2= new Thread(method2);
            Thread t3= new Thread(method3);
            Thread t4= new Thread(method4);
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();
            Console.WriteLine("Both threads are finished");
        }
    }
}
