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

            Delegates.PerformClaculation(3, 5, "add");
            Delegates.PerformClaculation(3, 5, "multiply");
            Delegates.PerformClaculation(3, 5);

            //Threads.RunThreads(4);

            Console.WriteLine(" ");
            Console.WriteLine("Done!");
        }
    }
}
