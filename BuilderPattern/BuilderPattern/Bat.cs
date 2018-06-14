using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    abstract class Bat : ICricketKit
    {
        public abstract string ShowName();

        public ISponsor ShowSponsor()
        {
            return new GM();
        }
    }
}
