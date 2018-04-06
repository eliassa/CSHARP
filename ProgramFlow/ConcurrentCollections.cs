using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{
    public class ConcurrentCollections
    {
        public static void BlockingCollection()
        {
            BlockingCollection<string> bc = new BlockingCollection<string>();
            Task read = Task.Run(() =>
            {
                foreach(string v in bc.GetConsumingEnumerable())
                    Console.WriteLine(v);
            });

            Task write = Task.Run(() =>
            {
                while (true)
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s)) break;

                    bc.Add(s);
                }
            });

            write.Wait();
        }

        public static void ConcurrenDict()
        {
            var dict = new ConcurrentDictionary<string, int>();
            if (dict.TryAdd("k1", 42))
                Console.WriteLine("Added");

            if (dict.TryUpdate("k1", 21, 42))
                Console.WriteLine("Updated to 21");

            dict["k1"] = 42; // Unconditional overwrite

            int r1 = dict.AddOrUpdate("k1", 3, (s, i) => i * 2);
            int r2 = dict.GetOrAdd("k2", 3);
        }
    }
}
