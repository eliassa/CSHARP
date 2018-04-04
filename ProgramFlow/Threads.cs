using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramFlow
{
    public static class Threads
    {
        public static void RunThreads(int numOfThreads)
        {
            for(int i = 0; i < numOfThreads; i++)
            {
                Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod))
                {
                    IsBackground = i % 2 == 1,
                    Name = "T" + i,
                    Priority = i == 2 ? ThreadPriority.Highest : ThreadPriority.Normal
                };
                Console.WriteLine("Starting thread " + t.Name);
                t.Start(t);
            }
        }

        private static void ThreadMethod(Object o)
        {
            Thread t = o as Thread;
            Console.WriteLine("Thread name: " + t.Name + ", IsAlive: " + t.IsAlive + ", IsBackground: " + t.IsBackground + ", Priority: " + t.Priority.ToString());
        }
    }
}
