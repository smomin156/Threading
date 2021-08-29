using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallelLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Factory.StartNew(() =>
            {
                Console.WriteLine("this way we create and start together");
            });

            Task task = new Task(() =>
              {
                  Console.WriteLine("this only creates ");
              });
            task.Start();

            Console.WriteLine("Hello from main");

            Console.ReadLine();
        }
    }
}
