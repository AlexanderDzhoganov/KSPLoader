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
            TestLib.Class1 foo = new TestLib.Class1();
            Console.WriteLine("GetFoo() returned {0}", foo.GetFoo());
            for (; ; ) ;
        }
    }
}
    