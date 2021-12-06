using Design_Patterns_Assignment.Strategy;
using System;

namespace Design_Patterns_Assignment
{
    internal class Strategy1
    {
        internal static void Run()
        {
            IMessageSender SmsSender = new SendSms();
            IMessageSender EmailSender = new SendEmail();
            IMessageSender FacebookMSener = new SendFacebookMess();
            

            Console.WriteLine("Message System");
            Console.WriteLine("---------------------");
            Console.WriteLine("  Write your message  ");
            Console.WriteLine("---------------------");
            string message = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(message))
            {
                ClearRow();
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
            Console.WriteLine("S: Send the message as a sms");
            Console.WriteLine("E: Send the message as an email");
            Console.WriteLine("F: Send the message as a Facebook message");
            Console.WriteLine("x: Exit Program");

            while (true)
            {
                // Get User Input
                char userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {                    
                    case 's' or 'S':
                        
                        Console.WriteLine("Sending sms");
                        SmsSender.Send(message);
                        break;

                    case 'e' or 'E':
                        
                        Console.WriteLine("Sending email");
                        EmailSender.Send(message);
                        break;

                    case 'f' or 'F':
                        
                        Console.WriteLine("Sending Facebook message");
                        FacebookMSener.Send(message);
                        break;

                    case 'x' or 'X':
                        
                        Console.WriteLine("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        
                        Console.Write("That is not a valid choice");
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

        private static void ClearRow()
        {
            // Set cursor below the menu
            Console.SetCursorPosition(1, 9);

            // Clear Row
            Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
        }


    }
}