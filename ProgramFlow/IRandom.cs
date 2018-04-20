using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramFlow
{

    public interface IRandom
    {
        string GetRandomString();

        int GetRandomInt();
    }

    public class Random : IRandom
    {
        public string GetRandomString()
        {
            return "Random";
        }

        public int GetRandomInt()
        {
            return 13;
        }
    }

    public class Random2 : IRandom
    {

        private int randomInt = 130;
        public string GetRandomString()
        {
            return "Random2";
        }

        public int GetRandomInt()
        {
            return randomInt;
        }
    }
}
