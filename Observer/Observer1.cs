using Design_Patterns_Assignment.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    class Observer1
    {               
        internal static void Run()
        {
            int waitTime = 5;

            //
            var timer = new Timer(Run2, null, 2, waitTime * 1000);
            Console.ReadLine();

            timer.Dispose();
            Console.ReadLine();
        }

        
        internal static void Run2(object state)
        {
            EmailPublisher publisher1 = new EmailPublisher("publisher1");
            EmailPublisher publisher2 = new EmailPublisher("publisher2");

            Subscriber subscriberA = new Subscriber("subscriberA");
            Subscriber subscriberB = new Subscriber("subscriberB");
            Subscriber subscriberC = new Subscriber("subscriberC");
            Subscriber subscriberD = new Subscriber("subscriberD");

            publisher1.Register(subscriberA);
            publisher1.Register(subscriberB);
            publisher1.Register(subscriberC);
            publisher2.Register(subscriberA);
            publisher2.Register(subscriberD);

            publisher1.Notify("\"this is email from publisher1\"");
            publisher2.Notify("\"Reklam from publisher2\"");

        }


    }
}
