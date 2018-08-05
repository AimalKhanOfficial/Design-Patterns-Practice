using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace AbstractFactoryAgain
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Drawing Dependency Injection
            var serviceProvider = new ServiceCollection()
                .AddSingleton<FactoryProducer>()
                .BuildServiceProvider();

            FactoryProducer fp = serviceProvider.GetService<FactoryProducer>();
            AbstractFactory abstractFactory = fp.GetFactory("Shape".ToUpper());
            Shape shape = abstractFactory.GetShape("Circle".ToUpper());
            shape.Draw();
            Console.ReadLine();
        }
    }
}