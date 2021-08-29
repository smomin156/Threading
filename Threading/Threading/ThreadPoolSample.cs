using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading
{
    class ThreadPoolSample
    {
        static void BackgroundTask(Object stateInfo)
        {
            Console.WriteLine("Hello! I'm a worker from ThreadPool");
            Thread.Sleep(1000);
        }
        static void BackgroundTask2(Object str)
        {
            string res = str as String;
            Console.WriteLine("Hello! " + str);
            Thread.Sleep(1000);
        }
        static void Main(string[] args)

        {
            // Use ThreadPool for a worker thread        
            ThreadPool.QueueUserWorkItem(BackgroundTask);
            ThreadPool.QueueUserWorkItem(BackgroundTask2, "Sameera");
            Console.WriteLine("Main thread does some work, then sleeps.");
            Thread.Sleep(500);
            Console.WriteLine("Main thread exits.");
            Console.ReadKey();
        }

    }
 }
