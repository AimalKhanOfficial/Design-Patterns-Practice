using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTemplateProject
{
    public class Observable : IObservable<string>
    {
        public List<IObserver<string>> Observers { get; set; }

        public Observable()
        {
            Observers = new List<IObserver<string>>();
        }

        public IDisposable Subscribe(IObserver<string> observer)
        {
            Observers.Add(observer);
            return new UnSubscriber(observer);
        }

        public void Notify(string msg)
        {
            Observers.ForEach(a =>
            {
                a.OnNext(msg);
            });
        }
    }
}
