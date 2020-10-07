using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Exception_Example
{
    class StringReadWrite
    {
        public static void StringReadWrite_Runner()
        {
            StringReadWrite_Method srw = new StringReadWrite_Method();
        }        
    }

    public class StringReadWrite_Method
    {
        StringBuilder sb = new StringBuilder();

        public StringReadWrite_Method()
        {
            WriteData();
            ReadData();
        }

        public void WriteData()
        {
            StringWriter sw = new StringWriter(sb);
            Console.WriteLine("Please enter your first and last name...");
            string name = Console.ReadLine();

            sw.WriteLine("Name: " + name);
            sw.Flush();
            sw.Close();
        }

        public void ReadData()
        {
            StringReader sr = new StringReader(sb.ToString());

            Console.WriteLine("Reading the information...");

            while (sr.Peek() > -1)
            {
                Console.WriteLine(sr.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Thank you!");

            sr.Close();
        }
    }
}
