using System;
using System.Collections;
using System.Collections.Generic;

namespace Exception_Example.Class_Hierarchies
{
    class IEnumerable_Example
    {
        public static void IEnumerable_Example1()
        {
            List<string> cars = new List<string>();
            cars.Add("Chevy");
            cars.Add("Honda");
            cars.Add("Ford");
            cars.Add("Lexus");

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("\n" + "Now our own collection..." + "\n");

            Car c = new Car();
            c[0] = "Chevy";
            c[1] = "Mercedes";
            c[2] = "Dodge";

            foreach (string car in c)
            {
                Console.WriteLine(car);
            }

        }

    }

    public class Car : IEnumerable
    {
        string[] car = new string[3];

        public string this[int carNum]
        {
            get { return car[carNum]; }
            set { car[carNum] = value; }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (string c in car)
            {
                yield return c;
            }
        }
    }
}
