using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBuilderPatternUnderstanding
{
    //The actual representation of the object
    class Representation
    {
        public Representation(String name)
        {
            this.BuilderName = name;
        }

        public String Caption { get; set; }
        public String BuilderName { get; set; }
    }
}
