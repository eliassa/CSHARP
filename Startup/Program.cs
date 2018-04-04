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


            Threads.RunThreads(4);

            Console.WriteLine(" ");
            Console.WriteLine("Done!");
        }
    }
}
