using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBuilderPatternUnderstanding
{
    internal class ConcreteBuilderTwo : IBuilder
    {
        private Representation rep = null;

        public ConcreteBuilderTwo()
        {
            rep = new Representation("ConcreteBuilderTwo");
        }

        public void BuildPartA()
        {
            rep.Caption = "Building Part A for Concrete Builder 2";
        }

        public void DisplayResults()
        {
            Console.WriteLine("Builder Name: {0}, Builder Caption: {1}", rep.BuilderName, rep.Caption);
        }
    }
}