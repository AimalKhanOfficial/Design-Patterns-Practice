using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    abstract class Person : ICloneable
    {
        public abstract String GetPersonName();

        public object Clone()
        {
            return base.MemberwiseClone();
        }
    }
}
