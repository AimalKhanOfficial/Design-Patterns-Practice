using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternMixedWithFactory
{
    class WirelessHeadPhones : IHeadPhones
    {
        public string ShowType()
        {
            return "Wireless Head Phones";
        }
    }
}
