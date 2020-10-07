using System;

namespace Exception_Example
{
    internal class Using_Properties_and_Fields
    {
        public static void Using_Prop_and_Fields()
        {
            Person p = new Person();
            p.Age = 91;
            p.Weight = 265;

            Console.WriteLine("Age: " + p.Age);
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        private int weight;

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if ((value > 0) && (value < 65))
                {
                    age = value;
                }
                else
                {
                    throw new Exception("Age cannot be over 65...");
                }
            }
        }
    }
}