using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    abstract class Ball : ICricketKit
    {
        public abstract string ShowName();

        public ISponsor ShowSponsor()
        {
            return new Addidas();
        }
    }
}
