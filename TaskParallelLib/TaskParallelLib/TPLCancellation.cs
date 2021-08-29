using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskParallelLib
{
    class TPLCancellation
    {
        static void Main(string[] args)
        {
            var cts = new CancellationTokenSource();
            var task1 = Task.Factory.StartNew(() =>
            {
                for (var i = 0; i < 10; i++)
                {
                    if (cts.Token.IsCancellationRequested)
                        break;
                    Console.WriteLine($"The Number is {i.ToString()}");
                    Thread.Sleep(2000);
                }
            }, cts.Token);

            Console.ReadKey();

            cts.Cancel();

            Console.WriteLine("Program Complete...");

        }
    }
}
