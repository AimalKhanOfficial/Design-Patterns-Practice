using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternMixedWithFactory
{
    abstract class PhoneWithWirelessHP : Item
    {
        public abstract string ShowName();

        public IHeadPhones ShowHeadPhones(HeadPhoneTypes type)
        {
            return HeadPhonesFactory.GetHeadPhones(type);
        }
    }
}
