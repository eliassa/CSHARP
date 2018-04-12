using System;
using System.Collections;

namespace CreateAndUseTypes
{
    public class GenericClass<T> where T : IEnumerable
    {
        public T whatever { get; set; }
        public Type t { get; set; }
        public GenericClass(T input)
        {
            whatever = input;
            t = input.GetType();
        }

        public override string ToString()
        {
            return "Type: " + t;
        }
    }
}
