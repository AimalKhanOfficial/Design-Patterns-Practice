using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternMixedWithFactory
{
    class IphoneX : PhoneWithWirelessHP
    {
        public override string ShowName()
        {
            return "Iphone X";
        }
    }
}
