using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLinq
{
    class Program
    {
        static void Main(string[] args)

        {

            // Using LINQ

            IEnumerable<int> rvals = Enumerable.Range(1, 100000000);

            var result = rvals.Where(x => x % 12345678 == 0).Select(x => x);

            Stopwatch sq = Stopwatch.StartNew();

            foreach (var item in result)

                Console.WriteLine(item);

            Console.WriteLine("Time taken for processing: " + sq.ElapsedMilliseconds + "ms");

            // Using PLINQ

            var result1 = rvals.AsParallel().Where(x => x % 12345678 == 0).Select(x => x);

            sq.Restart();

            foreach (var item in result1)

                Console.WriteLine(item);

            Console.WriteLine("Time taken for processing: " + sq.ElapsedMilliseconds + "ms");

            Console.ReadLine();

        }
    }
}
