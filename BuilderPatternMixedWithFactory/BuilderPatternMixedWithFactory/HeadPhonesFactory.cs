using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternMixedWithFactory
{
    class HeadPhonesFactory
    {
        public static IHeadPhones GetHeadPhones(HeadPhoneTypes headPhoneTypes)
        {
            if (headPhoneTypes.Equals(HeadPhoneTypes.Wireless))
            {
                return new WirelessHeadPhones();
            }
            else if (headPhoneTypes.Equals(HeadPhoneTypes.Wired))
            {
                return new WiredHeadPhones();
            }
            else
            {
                return null;
            }
        }
    }
}
