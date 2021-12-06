using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy
{
    class SendEmail : ISendEmail
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sent \"{message}\" as an email\n");
        }
    }
}
