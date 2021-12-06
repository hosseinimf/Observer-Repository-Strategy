using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy
{
    interface ISendMessage
    {
        public IMessageSender Sender { get; set; }

        void Send(string message);
    }
}
