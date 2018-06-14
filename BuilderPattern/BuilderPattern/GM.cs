using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class GM : ISponsor
    {
        public string ShowSponsor()
        {
            return "GM";
        }
    }
}
