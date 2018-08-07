using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBuilderPatternUnderstanding
{
    class Director
    {
        public Director(IBuilder buildParam)
        {
            buildParam.BuildPartA();
            buildParam.DisplayResults();
        }
    }
}
