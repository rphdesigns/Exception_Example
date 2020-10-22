using System;

namespace Exception_Example
{
    internal class CastAndConvertExample
    {
        public static void CastAndConvertExample1()
        {
            int num = 2147483647;
            long bigNum = num;

            int i = 5;
            double d = 10.5;
            i = (int)d;

            Console.WriteLine("The double variable d converted to int: " + i);
        }

        public static void CastAndConvertExample2()
        {
            int x = 7;
            double y = 12.6;
            x = (int)y;
            Console.WriteLine("Double casted to int: " + x);
            //Cast will just drop any number after the decimal place

            int xx = 7;
            double yy = 12.6;
            xx = Convert.ToInt32(yy);
            Console.WriteLine("Double casted to int: " + xx);
            //Convert will rount up if number is a decimal
        }

        public static void CastAndConvertExample3()
        {
            string str = "123";
            int r;
            r = Convert.ToInt32(str);
            Console.WriteLine("Using Convert to convert string to int: " + r);
        }
    }
}