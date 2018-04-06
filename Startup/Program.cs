using ProgramFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting...");
            Console.WriteLine(" ");

            Console.WriteLine("Threads & Delegates");
            Tasks.RunTasks(new Action[]{
                new Action(() => Delegates.PerformClaculation(3, 5, "add")),
                new Action(() => Delegates.PerformClaculation(3, 5, "multiply")),
                new Action(() => Delegates.PerformClaculation(3, 5))
            });
            Tasks.TaskCancelation();
            Console.WriteLine(" ");

            Console.WriteLine("PLINQ");
            Plinq.FireUpSomePlinqStuff();
            Console.WriteLine(" ");

            Console.WriteLine("Lock");
            Locks.InterLocking();
            Console.WriteLine(" ");

            Console.WriteLine("Concurrent collections");
            ConcurrentCollections.BlockingCollection();
            Console.WriteLine(" ");

            //Threads.RunThreads(4);

            Console.WriteLine(" ");
            Console.WriteLine("Done!");
        }
    }
}
