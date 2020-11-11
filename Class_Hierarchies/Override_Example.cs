using System;
namespace Exception_Example.Types_Examples
{
    class Override_Example
    {
        public static void Override_Example1()
        {
            Override_Patient p = new Override_Patient();
            p.Examine();

            Override_Adult a = new Override_Adult();
            a.Examine();

            Override_Patient pa = new Override_Adult();
            pa.Examine();
        }
    }

    public class Override_Patient
    {
        public virtual void Examine()
        {
            Console.WriteLine("The patient has been examined...");
        }
    }

    public class Override_Adult : Override_Patient
    {
        public override void Examine()
        {
            Console.WriteLine("The adult has been examined...");
        }
    }
}
