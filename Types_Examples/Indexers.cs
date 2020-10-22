using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Example.Types_Examples
{
    class Indexers
    {
        public static void Indexers_Example()
        {
            Car c = new Car();
            c[1] = "Ford";
            c[2] = "Dodge";
            c[3] = "Chevy";
            c[4] = "Honda";

            Console.WriteLine("Car 1 is: " + c[1]);
            Console.WriteLine("Car 2 is: " + c[2]);
            Console.WriteLine("Car 4 is: " + c[41]);
        }

        public class Car
        {
            string[] car = new string[40];

            public string this[int carNum]
            {
                get
                {
                    if (carNum >= 0 && carNum < car.Length)
                    {
                        return car[carNum];
                    }
                    return "Out of index range...";
                }
                set
                {
                    if (carNum >= 0 && carNum < car.Length)
                    {
                        car[carNum] = value;
                    }
                }
            }
        }
    }
}
