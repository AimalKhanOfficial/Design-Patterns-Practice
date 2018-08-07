using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBuilderPatternUnderstanding
{
    class ConcreteBuilderOne : IBuilder
    {

        private Representation rep = null;

        public ConcreteBuilderOne()
        {
            rep = new Representation("ConcreteBuilderOne");
        }

        public void BuildPartA()
        {
            rep.Caption = "Building Part A for Concrete Builder 1";
        }

        public void DisplayResults()
        {
            Console.WriteLine("Builder Name: {0}, Builder Caption: {1}", rep.BuilderName, rep.Caption);
        }
    }
}
