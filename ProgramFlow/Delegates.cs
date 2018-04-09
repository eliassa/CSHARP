using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{
    public static class Delegates
    {
        public delegate void Claculate(int x, int y);
        public delegate int Calculate(IEnumerable<int> ListOfIntegers);

        public static void PerformClaculation(int x, int y, string op = null)
        {
            Claculate cal;
            Console.WriteLine("Claculation in process...");
            switch(op) {
                case "add":
                    cal = (a, b) => Console.WriteLine("add: " + (a + b));
                    goto Exec;
                case "multiply":
                    cal = (a, b) => Console.WriteLine("multiply: " + (a * b));
                    goto Exec;
                case null:
                    cal = (a, b) => Console.WriteLine("add: " + (a + b));
                    cal += (a, b) => Console.WriteLine("multiply: " + (a * b));
                    goto Exec;
                default: throw new Exception(op + " is not a valid operator");
            }
            
            Exec:
            cal?.Invoke(x, y);
        }

        public static int DelegateMulticasting(int x, int y)
        {
            Calculate cal;
            List<int> ints = new List<int>() { 12, 16, 200, 73 };

            cal = (IEnumerable<int> a) =>
            {
                Console.WriteLine("1st");
                return a.Sum();
            };

            cal += (IEnumerable<int> a) =>
            {
                Console.WriteLine("2nd");
                return a.Max();
            };

            cal += (IEnumerable<int> a) =>
            {
                Console.WriteLine("3rd");
                return a.Last();
            };

            return cal(ints);
        }
    }
}
