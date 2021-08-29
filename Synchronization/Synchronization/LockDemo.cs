using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Synchronization
{
    class LockDemo
    {
        decimal totalBalance = 50000;

        static void Main(string[] args)
        {
            LockDemo lockDemo = new LockDemo();
            lockDemo.WithDraw(5000);
            Console.WriteLine("hello from main");
            Console.ReadLine();
        }

        public  void WithDraw(decimal amount)
        {
            lock (this)
            {
                if (amount > totalBalance)
                {
                    Console.WriteLine("Insufficient Amount.");
                }

                totalBalance -= amount;
                Console.WriteLine("Total Balance {0}", totalBalance);
            }
        }
    }
}
