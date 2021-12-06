using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy
{
    class SendMessage : ISendMessage
    {
        public IMessageSender Sender { get; set; }

        public void Send(string message)
        {
            Sender.Send(message);
        }
    }
}
