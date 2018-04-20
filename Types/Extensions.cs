using System;
using System.Collections.Generic;
using System.Text;

namespace Types
{
    public static class Extensions
    {
        public static bool RetrunTrue(this EmptyClass ec)
        {
            return true;
        }
    }

    public class EmptyClass
    {
        public EmptyClass()
        {
            this.RetrunTrue();
        }
    }
}
