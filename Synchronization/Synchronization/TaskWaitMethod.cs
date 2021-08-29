using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Synchronization
{
    class TaskWaitMethod
    {
        static void Main(string[] args)
        {
            Task task = Task.Run(() =>
            {
            Random randomNumbers = new Random();
            long sum = 0;
            int count = 1000000;
            for (int i = 1; i <= count; i++)
            {
                int randomNumber = randomNumbers.Next(0, 101);
                sum += randomNumber;
            }

            Console.WriteLine("Total:{0}", sum);
            Console.WriteLine("Count: {0}", count);
        });
            task.Wait();
            Console.WriteLine("Hello this is main");

            Console.ReadLine();
        } 
    }
}
