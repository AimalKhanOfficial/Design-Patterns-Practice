using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternMixedWithFactory
{
    class WiredHeadPhones : IHeadPhones
    {
        public string ShowType()
        {
            return "Wired Head Phones";
        }
    }
}
