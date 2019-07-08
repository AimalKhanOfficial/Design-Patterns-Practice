using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTemplateProject
{
    public class Subscriber
    {
        public void SubsribeTo(Subject subject)
        {
            subject.Attach(this);
        }

        public void Update(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
