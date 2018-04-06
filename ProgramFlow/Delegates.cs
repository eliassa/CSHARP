using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{
    public static class Delegates
    {
        public delegate void Calculate(int x, int y);

        public static void PerformClaculation(int x, int y, string op = null)
        {
            Calculate cal;
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
    }
}
