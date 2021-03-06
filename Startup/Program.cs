﻿using Types;
using ProgramFlow;
using System;
using System.CodeDom;
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

            //Console.WriteLine("Threads & Delegates");
            //Tasks.RunTasks(new Action[]{
            //    new Action(() => Delegates.PerformClaculation(3, 5, "add")),
            //    new Action(() => Delegates.PerformClaculation(3, 5, "multiply")),
            //    new Action(() => Delegates.PerformClaculation(3, 5))
            //});
            //Tasks.TaskCancelation();
            //Threads.RunThreads(4);
            //Console.WriteLine("Delegate Multicasting: " + Delegates.DelegateMulticasting(200, 50));
            //Console.WriteLine(" ");

            //Console.WriteLine("PLINQ");
            //Plinq.FireUpSomePlinqStuff();
            //Console.WriteLine(" ");

            //Console.WriteLine("Lock");
            //Locks.InterLocking();
            //Console.WriteLine(" ");

            //Console.WriteLine("Concurrent collections");
            //ConcurrentCollections.BlockingCollection();
            //Console.WriteLine(" ");


            //Console.WriteLine("Events");
            //Events.RunWorker();
            //Console.WriteLine(" ");

            //GenericClass<List<int>> gc = new GenericClass<List<int>>(new List<int>());
            //Console.WriteLine(gc.ToString());

            //Conversion.DoSomeConversion();

            //DynamicTypes.DoSomeDynamicCoding();
            //DynamicTypes.HavingFunWithExpandoObject();

            //Attributes.DoSomeAtributeStuff();
            //Reflection.DoSomeReflectionStuff();

            //CodeCompileUnit compileUnit = new CodeCompileUnit();

            CodeDOMstuff.DoSomeCodeDOMStuff();

            Console.WriteLine(" ");
            Console.WriteLine("Done!");
        }
    }
}
