using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    } 
     class DataPassing
    {
        public static void Main(string[] args)
        {
            Thread workerThread = new Thread(DataPassing.PrintJob);
            // Start thread with a parameter  
            workerThread.Start("Analyst");

            Person person1 = new Person() { Name="sameera",Age=20};
            Thread workerThread2 = new Thread(DataPassing.PrintPerson);
            workerThread2.Start(person1);

            Console.ReadLine();
        }

        public static void PrintJob(object data)
        {
            Console.WriteLine("Background PrintJob started.");
            Thread.Sleep(1000);
            Console.WriteLine("PrintJob still printing...");
            Console.WriteLine($"Data: {data}");
            Thread.Sleep(1000);
            Console.WriteLine("PrintJob finished.");
        }

        public static void PrintPerson(object data)
        {
            Console.WriteLine("Background PrintPerson started.");
            Thread.Sleep(1000);
            Console.WriteLine("PrintPerson still printing...");
            Person p = (Person)data;
            Console.WriteLine($"Person {p.Name} is of {p.Age} age.");
            Thread.Sleep(1000);
            Console.WriteLine("PrintPerson finished.");
        }

    }
}
