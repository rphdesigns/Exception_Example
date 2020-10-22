using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Example.Inheritance
{
    class InheritanceExample
    {
        public static void InheritanceExample1()
        {
            Patient p = new Patient();
            p.Examine("Heesch");

            Child c = new Child();
            c.Examine("Michael");
            c.Inoculate();

            UnderFive uf = new UnderFive();
        }
    }

    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public long SSN { get; set; }

        public void Examine(string pname)
        {
            Console.WriteLine("Examination of " + pname + " completed");
        }

        public void Billing(long ssn)
        {
            Console.WriteLine("Billing completed...");
        }
    }

    //Child : Patient = child now inheriting from Paitent
    public class Child : Patient
    {
        public void Inoculate()
        {
            Console.WriteLine("Child has been inoculated...");
        }
    }

    //UnderFive is inheriting from Child which inherits from Paitent
    public class UnderFive : Child
    {
        public void UnderFiveMethod()
        {
            Console.WriteLine("UnderFive method has been called...");
        }
    }
}
