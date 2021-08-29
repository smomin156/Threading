using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Synchronization
{
    class JoinMethod
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Method1);
            thread1.Start();

            Thread thread2 = new Thread(Method2);
            thread2.Start();

            thread1.Join();
            Console.WriteLine("Thread1 completed");

            thread2.Join();
            Console.WriteLine("Thread2 completed");

            Console.WriteLine("hello from main");
            Console.ReadKey();

        }

        private static void Method2(object obj)
        {
            Console.WriteLine("Thread2 Executed.");
        }

        private static void Method1(object obj)
        {
            Console.WriteLine("Thread1 Executed");
        }
    }
}
