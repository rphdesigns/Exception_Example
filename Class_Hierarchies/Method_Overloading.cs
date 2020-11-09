using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Example.Inheritance
{
    class Method_Overloading
    {

        public static void Method_Overloading_Example()
        {
            Overloading_Patient p = new Overloading_Patient();
            p.CheckBilling();
            p.CheckBilling(3, 3);
            p.CheckBilling("Mark", 3);

            Overloading_Child c = new Overloading_Child();
            c.CheckBilling("b", "c");

        }
    }

    public class Overloading_Patient
    {
        public void CheckBilling()
        {
            Console.WriteLine("Patient: The billing has been checked...");
        }

        public void CheckBilling (int a , int b)
        {
            Console.WriteLine("Patient: The billing has been checked using two submitted integers...");
        }

        public void CheckBilling (string a, int b)
        {
            Console.WriteLine("Patient: The billing has been checked using a submitted string and integer...");
        }
    }

    public class Overloading_Child : Overloading_Patient
    {
        public void CheckBilling(string a, string b)
        {
            Console.WriteLine("Child: The billing has been checked by submitting two strings...");
        }
    }
}
