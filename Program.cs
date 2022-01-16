using Autofac;
using Design_Patterns_Assignment;
using Design_Patterns_Assignment.Strategy;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //just to create an instance of IStrategyApp
            var container = AFConfig.Configure();
            using var scope = container.BeginLifetimeScope();
            var strategyApp = scope.Resolve<IStrategyApp>();

            Repository1 Repository1 = new Repository1();


            Console.WriteLine("-----------------Main menu----------------");
            Console.WriteLine("Please select a project");           
            Console.WriteLine("O: Observer");
            Console.WriteLine("R: Repository");
            Console.WriteLine("S: Strategy");

            while (true)
            {
                char userInput = Console.ReadKey(true).KeyChar;
                switch (userInput)
                {                   
                    case 'o' or 'O':
                        Observer1.Run();
                        break;

                    case 'r' or 'R':
                        Repository1.Run();
                        break;

                    case 's' or 'S':
                            strategyApp.Run();
                        break;

                    default:
                        Console.Write("That is not a valid choice");
                        break;
                }
            }
            





            //Decorator1.Run();
            //Repository1.Run();
            //Strategy1.Run();
            //Observer1.Run();
        }     
    }
}
