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

        public static void Add(int a, int b) {  Console.WriteLine("add: " + (a+b)); }

        public static void Multiply(int a, int b) { Console.WriteLine("multiply: " + (a*b)); }

        public static void PerformClaculation(int x, int y, string op = null)
        {
            Calculate cal;
            switch(op) {
                case "add":
                    cal = Add;
                    break;
                case "multiply":
                    cal = Multiply;
                    break;
                case null:
                    cal = Add;
                    cal += Multiply;
                    break;
                default: throw new Exception(op + " is not a valid operator");
            }
            cal(x, y);
        }
    }
}
