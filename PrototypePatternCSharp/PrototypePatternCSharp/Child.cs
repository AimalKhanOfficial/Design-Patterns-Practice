using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternCSharp
{
    class Child : Parent
    {
        public String Id { get; set; }

        public Parent Clone()
        {
            return (Parent)this.MemberwiseClone();
        }
    }
}
