using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Example
{
    class Static_Example
    {
        public void Static_Example_Main ()
        {
            double r = Math.Round(35.3);
            Console.WriteLine(r);

            //using instance of static class
            Car.Accelerate();

            //using instance of non static class
            Car c = new Car();
            c.SlowDown();


        }
    }

    public class Car
    {
        public static void Accelerate()
        {
            Console.WriteLine("Car is accelerating...");
        }

        public void SlowDown()
        {
            Console.WriteLine("Car is slowing down...");
        }
    }
}
