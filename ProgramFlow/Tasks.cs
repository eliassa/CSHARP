using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramFlow
{
    public class Tasks
    {


        public static void RunTasks(Action[] actions)
        {
            List<Task> tasks = new List<Task>();

            foreach(Action a in actions)
            {
                tasks.Add(Task.Run(a).ContinueWith((i) => Console.WriteLine("Done executing a task")));
            }

            Task.WaitAll(tasks.ToArray());
        }

        public static void TaskCancelation()
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            Task task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.WriteLine("*");
                    Thread.Sleep(1000);
                }
            }, token);

            Thread.Sleep(5000);
            cts.Cancel();
        }
    }
}
