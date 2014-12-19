using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestExecutable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TestFoo() returned {0}", TestLib.Test.TestFoo());

            Console.WriteLine("ReturnNewFoo().GetFoo() returned {0}", TestLib.Test.ReturnNewFoo().GetFoo());

            for (; ; ) ;
        }
    }
}
    