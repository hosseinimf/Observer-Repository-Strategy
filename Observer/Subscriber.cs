using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer
{
    class Subscriber : IObserver
    {
        public string SubscriberName { get; set; }

        public Subscriber(string subscriberName)
        {
            SubscriberName = subscriberName;
        }

        public void ReceiveEmail(string email)
        {
            
            Console.WriteLine($"{SubscriberName} received this {email}");
           
        }
    }
}
