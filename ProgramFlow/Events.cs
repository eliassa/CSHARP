using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{
    public class Events
    {

        public void CreateAndRaise()
        {
            Pub p = new Pub();
            p.OnChange += (sender, e) => Console.WriteLine("Event raised: {0}", e.Value);
        }

    }

    public class MyEventArgs : EventArgs
    {
        public int Value { get; set; }

        public MyEventArgs(int value)
        {
            Value = value;
        }

    } 

    public class Pub
    {
        public event EventHandler<MyEventArgs> OnChange = delegate { };

        public void Raise()
        {
            OnChange(this, new MyEventArgs(50));
        }
      
    }

}
