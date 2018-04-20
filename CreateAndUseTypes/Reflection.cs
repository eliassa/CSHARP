using ProgramFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CreateAndUseTypes
{
    public class Reflection
    {

        public static void DoSomeReflectionStuff()
        {
            // Find all implementations of the IRandom interface in the ProgramFlow assembly.
            Assembly a = Assembly.Load("ProgramFlow");
            var randoms = from type in a.GetTypes()
                    where typeof(IRandom).IsAssignableFrom(type) && !type.IsInterface
                    select type;


            IRandom random = null;
            // Create an instance of each of the implementations found.
            foreach (Type t in randoms)
            {
                random = Activator.CreateInstance(t) as IRandom;
                Console.WriteLine(random.GetRandomString());
            }



            // Using reflection to get a private field from a calss in antoher assembly
            FieldInfo[] fields = random.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            foreach (var field in fields)
            {
                if(field.FieldType == typeof(int))
                {
                    Console.WriteLine(field.GetValue(random));
                }
            }
        }
    }
    

}
