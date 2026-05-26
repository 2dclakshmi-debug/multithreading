using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace multithreading
{
    internal class CheckIsActive
    {
        public static void method()
        {
            Console.WriteLine("Thread is running.......");
        }
        //static void Main(string[] args)
        //{
        //    Thread t = new Thread(method);
        //    t.Start();
        //    Console.WriteLine(t.IsAlive);
        //    t.Join();
        //    Console.WriteLine("Thread finished");
        //    Console.WriteLine(t.IsAlive);
        //}
    }
}
