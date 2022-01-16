using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy
{
    internal interface IStrategyApp
    {
        ISendMessage SendMessage { get; set; }
        IMessageSender EmailSender { get; set; }
        IMessageSender SmsSender { get; set; }
        IMessageSender FacebookMesSender { get; set; }

        void Run();
    }
}
