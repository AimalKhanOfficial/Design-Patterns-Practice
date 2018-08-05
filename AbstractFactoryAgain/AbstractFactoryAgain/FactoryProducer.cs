using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryAgain
{
    class FactoryProducer
    {
        public AbstractFactory GetFactory(String factoryName)
        {
            AbstractFactory absFactory = null;
            switch (factoryName)
            {
                case "SHAPE":
                    absFactory = new ShapeFactory();
                    break;
                case "COLOR":
                    absFactory = new ColorFactory();
                    break;
            }
            return absFactory;
        }
    }
}
