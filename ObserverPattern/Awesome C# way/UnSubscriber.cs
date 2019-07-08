using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTemplateProject
{
    public class UnSubscriber : IDisposable
    {
        public IObserver<string> Observer { get; set; }

        public UnSubscriber(IObserver<string> observer)
        {
            Observer = observer;
        }

        public void Dispose()
        {
            //Dispose observer
        }
    }
}
