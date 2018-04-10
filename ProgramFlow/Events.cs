using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramFlow
{
    //public delegate int WorkPerformedHandler(object sender, WorkPerformedEventArgs e);

    public class Events
    {
        public static void RunWorker()
        {
            var worker = new Worker();
            worker.WorkPerformed += Worker_WorkPerformed;
            worker.WorkCompleted += (object sender, EventArgs e) => Console.WriteLine("Work completed!!");
            worker.DoWork(8, "Documenting");
        }

        private static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine("Hours worked: " + e.Hours + " " + e.WorkType);
        }
        
    }

    public class Worker
    {
        //public event WorkPerformedHandler WorkPerformed;
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;

        public void DoWork(int hours, string workType)
        {
            for(int i  = 0; i < hours; i++)
            {
                Thread.Sleep(1000);
                OnWorkPerformed(i + 1, workType);
            }
            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(int hours, string workType)
        {
            if (WorkPerformed is EventHandler<WorkPerformedEventArgs> del)
                del(this, new WorkPerformedEventArgs(hours, workType));
        }

        protected virtual void OnWorkCompleted()
        {
            if (WorkCompleted is EventHandler del)
                WorkCompleted(this, EventArgs.Empty);
        }
    }

    public class WorkPerformedEventArgs : System.EventArgs
    {
        public WorkPerformedEventArgs(int hours, string workType)
        {
            Hours = hours;
            WorkType = workType;
        }

        public int Hours { get; set; }
        public string WorkType { get; set; }

    }



}
