using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Example
{
    class Constructor_Example
    {
        public static void ConstructorExample()
        {
            AddConstructor ac = new AddConstructor();

        }
    }

    public class DefConstructor
    {
        public void DoThis()
        {
            Console.WriteLine("DoThis has run...");
        }
    }

    public class AddConstructor
    {
        public AddConstructor()
        {
            Console.WriteLine("The constructor has been called...");
            DoThat();
        }

        public void DoThat()
        {
            Console.WriteLine("DoThat has executed...");
        }
    }
}
