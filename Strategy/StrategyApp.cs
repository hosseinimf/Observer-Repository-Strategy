using Design_Patterns_Assignment.Strategy;
using System;

namespace Design_Patterns_Assignment
{
    internal class StrategyApp : IStrategyApp
    {
        
        public ISendMessage SendMessage { get; set; }
        public IMessageSender EmailSender { get; set; }
        public IMessageSender SmsSender { get; set; }
        public IMessageSender FacebookMesSender { get; set; }


        public StrategyApp(ISendMessage sendMessage, ISendEmail emailSender, ISendSms smsSender, ISendFacebookMess facebookMesSender)
        {
            SendMessage = sendMessage;
            EmailSender = emailSender;
            SmsSender = smsSender;
            FacebookMesSender = facebookMesSender;

            sendMessage.Sender = smsSender;
        }





        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Message System");
            Console.WriteLine("---------------------");
            Console.WriteLine("  Write your message  ");
            Console.WriteLine("---------------------");
            string message = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(message))
            {
                Console.WriteLine("Message System");
                Console.WriteLine("---------------------");
                Console.WriteLine("  Please write your message  ");
                Console.WriteLine("---------------------");
                message = Console.ReadLine();
            }


            Console.WriteLine("Message System");
            Console.WriteLine("---------------------");
            Console.WriteLine("  Select an action   ");
            Console.WriteLine("---------------------");
            Console.WriteLine("T: Send the message");
            Console.WriteLine("S: Select as a sms");
            Console.WriteLine("E: Select as an email");
            Console.WriteLine("F: Select as a Facebook message");
            Console.WriteLine("x: Exit Program");

            while (true)
            {
                // Get User Input
                char userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 't' or 'T':
                        SendMessage.Send(message);
                        break;

                    case 's' or 'S':
                        Console.WriteLine("Sending sms");
                        SendMessage.Sender = SmsSender;
                        break;

                    case 'e' or 'E':
                        Console.WriteLine("Sending email");
                        SendMessage.Sender = EmailSender;
                        break;

                    case 'f' or 'F':
                        Console.WriteLine("Sending Facebook message");
                        SendMessage.Sender = FacebookMesSender;
                        break;

                    case 'x' or 'X':
                        Console.WriteLine("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("That is not a valid choice");
                        break;
                }
            }










            //// Refactor this code so that it uses the strategy Pattern
            //Console.WriteLine("Strategy");
            //var message = "This is the message";
            //MessageHandler.SendEmail(message);
            //MessageHandler.SendSMS(message);
            //MessageHandler.SendFacebookMessage(message);

            //// What i want to happen to happen is
            ////
            //// Change type of message to send to sms etc.
            //// send message            
        }

    }
}