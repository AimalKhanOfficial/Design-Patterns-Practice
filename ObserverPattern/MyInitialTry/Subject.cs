using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTemplateProject
{
    public class Subject
    {
        public List<Subscriber> Subscribers { get; set; }

        public Subject()
        {
            Subscribers = new List<Subscriber>();
        }

        public void Attach(Subscriber subscriber)
        {
            Subscribers.Add(subscriber);
        }

        public void Notify(string msg)
        {
            Subscribers.ForEach(a =>
            {
                a.Update(a.GetHashCode().ToString() + " updated: " + msg);
            });
        }
    }
}
