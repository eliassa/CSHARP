using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{
    class StaticSingelton
    {
        public StaticSingelton _instance = new StaticSingelton();

        private StaticSingelton()
        {

        }

        public StaticSingelton GetInstance()
        {
            return _instance;
        }
    }
}
