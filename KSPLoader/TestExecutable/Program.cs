using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExecutable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TestFoo() returned {0}", TestLib.Test.TestFoo());
            for (; ; ) ;
        }
    }
}
    