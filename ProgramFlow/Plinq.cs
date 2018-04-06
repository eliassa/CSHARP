using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{
    public static class Plinq
    {
        public static void FireUpSomePlinqStuff()
        {
            try
            {
                var numbers = Enumerable.Range(0, 20);
                var parallelResult = numbers.AsParallel().AsOrdered().Where(i => {
                    if (i == 10)
                        throw new ArgumentException("EXCEPTION");
                    return i % 2 == 0;
                });

                parallelResult.ForAll(e => Console.WriteLine(e));

            }
            catch(AggregateException e)
            {
                Console.WriteLine("{0} exeptions where thrown", e.InnerExceptions.Count);
            }
            
        }
    }
}
