using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Exception_Example.Asyn_Programming
{
    class Multithreading_Example
    {
        public static void Multithreading_Example1()
        {

            Thread t = new Thread(WriteX);
            t.Start();


            for (int i = 0; i < 1000; i++)
            {
                Console.Write("O");
            }

        }

        static void WriteX()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(".");
            }
        }
    }
}
