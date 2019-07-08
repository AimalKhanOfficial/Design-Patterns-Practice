using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTemplateProject
{
    public class Observer : IObserver<string>
    {
        public IDisposable UnsubscriptionRef { get; set; } 

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void SubsribeTo(Observable observable)
        {
            UnsubscriptionRef = observable.Subscribe(this);
        }

        public void Unsubscribe()
        {
            UnsubscriptionRef.Dispose();
        }

        public void OnNext(string value)
        {
            Console.WriteLine(value);
        }
    }
}
