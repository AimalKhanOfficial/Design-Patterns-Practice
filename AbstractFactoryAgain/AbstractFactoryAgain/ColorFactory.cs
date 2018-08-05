using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryAgain
{
    class ColorFactory : AbstractFactory
    {
        public override Color GetColor(string color)
        {
            Color colorRef = null;
            switch (color)
            {
                case "RED":
                    colorRef = new Red();
                    break;
            }
            return colorRef;
        }

        public override Shape GetShape(string shape)
        {
            throw new NotImplementedException();
        }
    }
}
