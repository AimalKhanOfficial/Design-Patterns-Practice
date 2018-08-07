using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBuilderPatternUnderstanding
{
    class Program
    {
        static void Main(string[] args)
        {
            //The abstract rep of the Builder
            IBuilder builder;

            //Choosing the concrete Builder 
            builder = new ConcreteBuilderOne();
           
            //Using the director class and actual creation of the complex object
            Director director = new Director(builder);

            Console.ReadLine();
        }
    }
}
