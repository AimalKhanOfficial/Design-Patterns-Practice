using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryAgain
{
    class ShapeFactory : AbstractFactory
    {
        public override Shape GetShape(string shape)
        {
            Shape shapeRef = null;
            switch (shape)
            {
                case "CIRCLE":
                    shapeRef = new Circle();
                    break;
            }
            return shapeRef;
        }

        public override Color GetColor(string color)
        {
            throw new NotImplementedException();
        }
    }
}
