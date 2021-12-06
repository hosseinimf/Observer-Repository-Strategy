using System;

namespace Design_Patterns_Assignment
{
    internal class MessageHandler
    {
        internal static void SendEmail(string message)
        {
            Console.WriteLine($"sending \"{message}\" as an email");
        }

        internal static void SendSMS(string message)
        {
            Console.WriteLine($"sending \"{message}\" as a sms");
        }

        internal static void SendFacebookMessage(string message)
        {
            Console.WriteLine($"sending \"{message}\" as a facebookmessage");
        }
    }
}