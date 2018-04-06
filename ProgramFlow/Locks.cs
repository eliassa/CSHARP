using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramFlow
{
    public static class Locks
    {
        public static void LockingStuffUp()
        {
            int a = 15;
            Object _lock = new object(); // Should be unreachable for external classes. Should also be a reference type to avoid boxing. 

            var up = Task.Run(() =>
            {
                for (int i = 0; i < 10000; i++)
                    lock (_lock) // Avoid locking up strings because of string-interning
                        a++;
            });

            for (int i = 0; i < 10000; i++)
                lock (_lock)
                    a--;

            up.Wait();
            Console.WriteLine(a);
        }

        public static void InterLocking()
        {
            int a = 15;
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 10000; i++)
                    Interlocked.Increment(ref a);
            });

            for (int i = 0; i < 10000; i++)
                Interlocked.Decrement(ref a);

            up.Wait();
            Console.WriteLine(a);
        }
    }
}
