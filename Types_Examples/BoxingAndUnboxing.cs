using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Example.Types_Examples
{
    class BoxingAndUnboxing
    {
        public static void BoxingAndUnboxing_Example1()
        {
            object o;
            int x = 25;

            o = x; //Boxing is taking place here, taking int x and moving it into an object
            Console.WriteLine("o= " + o);
            Console.WriteLine("x= " + x);

            o = 123;
            x = (int)o;
            Console.WriteLine("o= " + o);
            Console.WriteLine("x= " + x);
        }
    }
}
