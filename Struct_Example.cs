using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Example
{
    public struct Struct_Example
    {
        public int x;
        public int y;
        public Struct_Example(int a, int b)
        {
            x = a;
            y = b;
        }
        public void DoThis()
        {
            Console.WriteLine(x + y);
        }
    }
}
