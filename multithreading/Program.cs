using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace multithreading
{
    internal class Program
    {
     static void method1()
        {
            Console.WriteLine("Thread1 is running");
        }
        static void method2()
        {
            Console.WriteLine("Thread2 is running");
        }

        static void Main(string[] args)
        {
            Thread t1=new Thread(method1);
            Thread t2=new Thread(method2);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine("Both threads are finished");
        }
    }
}
