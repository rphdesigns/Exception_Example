using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Example
{
    class CollectionsandArrays
    {
        public static void CollectionsandArrays_Method()
        {
            // Create a collection that is a list of strings

            var dogs = new List<string>();

            dogs.Add("Bulldog");
            dogs.Add("Collie");
            dogs.Add("Lab");

            // foreach to move through the list
            //foreach (var dog in dogs)
            //{
            //    Console.WriteLine(dog + " ");
            //}

            // Console.WriteLine(dogs[1]);

            int[] a1 = new int[] { 1, 3, 5, 7, 9, 11 };

            foreach (int i in a1)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
