using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternMixedWithFactory
{
    interface Item
    {
        string ShowName();
        IHeadPhones ShowHeadPhones(HeadPhoneTypes types);
    }
}
