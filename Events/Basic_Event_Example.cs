using System;
namespace Exception_Example.Events
{
    class Basic_Event_Example
    {
        public static void Basic_Event_Example1()
        {
            //Instantiate an event publisher object
            EvtPublisher ep = new EvtPublisher();

            //Instantiate an event subscriber object
            EvtSubscriber es = new EvtSubscriber();
            ep.evt += es.HandleTheEvent;

            //Call the CheckBalance method on the ep object
            //it will invoke the ep.evt delegate if the balance exceeds 250
            ep.CheckBalance(251);

        }
    }

    public class EvtPublisher
    {
        //public delegate void del(string x);

        //public event del evt;

        public EventHandler<EvtArgsClass> evt;

        public void CheckBalance(int x)
        {
            if (x > 250)
            {
                EvtArgsClass eac = new EvtArgsClass("Balance Exceeds 250...");
                evt(this, eac);
            }
        }
    }

    public class EvtSubscriber
    {
        public void HandleTheEvent(object sender, EventArgs e)
        {
            Console.WriteLine("ATTENTION! " + sender + "is advising that the balance is over 250...");
        }
    }

    public class EvtArgsClass : EventArgs
    {
        public EvtArgsClass(string str)
        {
            msg = str;
        }

        private string msg;
        public string Message
        {
            get { return msg; }
        }
    }
}
