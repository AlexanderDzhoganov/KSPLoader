﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestLib
{
    public class Foo
    {
        private float foo = 5.0f;

        public float GetFoo()
        {
            return foo * 2.0f;
        }
    }

    public static class Test
    {

        public static float TestFoo()
        {
            Foo foo = new Foo();
            return foo.GetFoo();
        }

        public static Foo ReturnNewFoo()
        {
            return new Foo();
        }

    }
}
