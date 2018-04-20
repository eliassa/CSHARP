using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Diagnostics;

namespace Types
{
    public class Attributes
    {

        public static void DoSomeAtributeStuff()
        {
            // Checking if an attribute is defined;
             if(Attribute.IsDefined(typeof(NumberBox), typeof(HelperAttribute))){
                    Console.WriteLine("The Attribute is defined");
             }

            // Getting an attribute instance
            HelperAttribute ha = (HelperAttribute)Attribute.GetCustomAttribute(typeof(NumberBox), typeof(HelperAttribute));
            Console.WriteLine(ha.Description);
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class HelperAttribute: Attribute
    {
        public string AttributeDescription = "Description of the attribute";
        public string Description = "";

        public HelperAttribute(string description)
        {
            Description = description; 
        }
    }

    [Helper("Denne klassen inneholder et tall")]
    public class NumberBox
    {
        public int Number;

        public int[] CachedItems = new int[] { 123, 14, 75, 17, 348, 2, 4 };

        private string SecretString;

        public NumberBox(int number)
        {
            Number = number;
            SecretString = "This string is secret";
        }

        public static int what()
        {
            return 10;
        }
    }
}
