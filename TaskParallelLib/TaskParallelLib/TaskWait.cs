using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallelLib
{
    class TaskWait
    {
        static void Main(string[] args)
        {
            //First method to create and start a Task using TPL  
            var task1 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("This is the first method ");
            });

            task1.Wait();

            //Second method to create a Task using TPL  
            var task2 = new Task(() =>
            {
                Console.WriteLine("This is the second method");
            });
            // Next, we have to start the Task  
            task2.Start();

            task2.Wait();

            Console.Write("Program Complete...");
            Console.ReadKey();
        }
    }
}
