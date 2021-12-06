using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Observer
{
    class EmailPublisher : ISubject
    {
        public string Name { get; set; }
        public string Email { get; set; }
        private List<IObserver> observerList;

        public EmailPublisher(string name)
        {
            Name = name;  
            observerList = new List<IObserver>();
        }

        public void SendEmail(string email)
        {            
            Notify(email);            
        }

        public void Register(IObserver observer)
        {
            observerList.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            observerList.Remove(observer);
        }

        public void Notify(string email)
        {
            foreach (var observer in observerList)
            {
                observer.ReceiveEmail(email);
            }
            Console.WriteLine();
        }
        
    }
}
