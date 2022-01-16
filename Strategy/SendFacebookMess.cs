using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy
{
    internal class SendFacebookMess : ISendFacebookMess
    {
        public void Send(string message)
        {
            Console.WriteLine($" \"{message}\" is sent as a facebook message\n");
        }
    }
}
