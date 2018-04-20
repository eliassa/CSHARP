using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Types
{
    public class DynamicTypes
    {
        public static void DoSomeDynamicCoding()
        {
            dynamic d = "Hello, wrold";

            Console.WriteLine(d);


            d = d.Length;

            Console.WriteLine(d);

        }

        public static void HavingFunWithExpandoObject()
        {
            dynamic dynamicDict = new ExpandoObject();

            dynamicDict.Name = "Elias";
            dynamicDict.Age = 14;
            dynamicDict.IsFemale = false;
            dynamicDict.Count = (Func<int>)(() => ((IDictionary<string, object>)dynamicDict).Count);

            foreach(var item in dynamicDict)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

            Console.WriteLine("Count: " + dynamicDict.Count());
        }
    }
}
