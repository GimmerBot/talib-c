using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using talib;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var tests = new Tests();
            var result =  tests.Test().Result;
        }
    }
}
