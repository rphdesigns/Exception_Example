using System;
namespace Exception_Example.Delegates
{
     class Delegate_Example
    {
        delegate int del(int x, int y);

        public static void Delegate_Example1()
        {
            Michael m = new Michael();

            del d = m.AddNumbers;
            Console.WriteLine(d(3, 4));

            d = m.MultiplyNumbers;
            Console.WriteLine(d(3, 4));

            d = m.DoAnotherThing;
            Console.WriteLine(d(3, 4));
        }
    }

    public class Michael
    {
        public int AddNumbers (int a, int b)
        {
            return a + b;
        }

        public int MultiplyNumbers (int a, int b)
        {
            return a * b;
        }

        public int DoAnotherThing(int x, int y)
        {
            return x + (y * 3);
        }
    }
}
