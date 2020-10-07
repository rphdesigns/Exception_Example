using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Example
{
    class Exception_Example
    {
        public static void Exception_Example_Method()
        {
            int a = 4;
            int b = 0;

            try
            {
                Console.WriteLine("a divided by b is: " + a / b);
            }
            catch (Exception e)
            {
                Console.WriteLine("The following error has occurred: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Finally has been called...");
            }

            Console.WriteLine("... the program continues...");
        }
        
    }
}
