using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Example.Class_Hierarchies
{
    class Explicit_Implementation_Example
    {
        public static void Example1 ()
        {
            Michael m = new Michael();
            ((IFirst)m).DoThis();
            ((ISecond)m).DoThis();
            
        }
    }

    interface IFirst
    {
        void DoThis();
    }

    interface ISecond
    {
        int DoThis();
    }

    public class Michael : IFirst, ISecond
    {
        public void DoThis()
        {
            Console.WriteLine("Implementation of IFirst.DoThis...");
        }

        int ISecond.DoThis()
        {
            Console.WriteLine("Implementation of ISecond.DoThis...");
            return 6;
        }

        public void Test()
        {

        }
    }
}
