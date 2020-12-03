using System;
namespace Exception_Example.Delegates
{
    class Multicast_Delegate_Example
    {
        delegate void del(int x, int y);

        public static void Multicast_Delegate_Example1()
        {
            Michael_Multicast m = new Michael_Multicast();

            del d;

            d = m.AddNumbers;
            Console.WriteLine("Invoiking delegate d with one target:");
            d(6, 5);
            Console.WriteLine();

            d += m.MultiplyNumbers;
            Console.WriteLine("Invoiking delegate d with two targets:");
            d(6, 5);
            Console.WriteLine();

            d += m.SubtractNumber;
            Console.WriteLine("Invoiking delegate d with three targets:");
            d(6, 5);
            Console.WriteLine();

            d -= m.MultiplyNumbers;
            Console.WriteLine("Invoiking delegate d without Multiply Numbers:");
            d(6, 5);
            Console.WriteLine();
        }
    }

    public class Michael_Multicast
    {
        public void AddNumbers (int a, int b)
        {
            Console.WriteLine("AddNumbers: a + b= " + (a + b));
        }

        public void MultiplyNumbers (int a, int b)
        {
            Console.WriteLine("Multiply Numbers: a * b= " + (a * b));
        }

        public void SubtractNumber(int a, int b)
        {
            Console.WriteLine("Subtract Numbers: a - b= " + (a - b));
        }
    }
}
