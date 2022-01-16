using Autofac;
using Design_Patterns_Assignment.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public static class AFConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<StrategyApp>().As<IStrategyApp>();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                 .Where(i => i.Namespace.Contains("Strategy"))
                 .As(i => i.GetInterfaces()
                 .FirstOrDefault(n => n.Name == "I" + i.Name))
                 .AsImplementedInterfaces();


            return builder.Build();
        }
    }
}
