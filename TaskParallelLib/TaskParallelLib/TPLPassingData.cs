using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallelLib
{
    class TPLPassingData
    {
        static void Main(string[] args)
        {
            var task1 = Task.Factory.StartNew<string>(() =>
            {
                Console.WriteLine("This is the first method ");
                return "Hello";
            });

            var value1 = task1.Result;

            var task2 = new Task<string>(new Func<object, string>((str) =>
            {
                Console.WriteLine("This is the second method ");
                return ($"{str} World!");
            }), value1);

            task2.Start();

            var value2 = task2.Result;

            Console.WriteLine($"{value2}");

            Console.Write("Program Complete...");
            Console.ReadLine();
        }
    }
}
