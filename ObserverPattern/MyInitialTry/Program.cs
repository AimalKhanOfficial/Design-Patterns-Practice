using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolvingTemplateProject
{
    /// <summary>
    /// 
    /// 
    /// 
    /// 
    /// </summary>

    class Program
    {
        public static void Main(string[] args)
        {
            var observable = new Subject();
            var sub1 = new Subscriber();
            var sub2 = new Subscriber();
            sub1.SubsribeTo(observable);
            sub2.SubsribeTo(observable);
            observable.Notify("Hi Subs!");
            Console.ReadKey();
        }
        /// <summary>
        /// foreach (var item in Hey())
        ///    {
        ///        Console.WriteLine(item);
        ///    }
        /// </summary>
        /// <returns></returns>
        //public static IEnumerable<int> Hey()
        //{
        //    for (var i = 1; i < 6; i++)
        //    {
        //        yield return i;
        //    }
        //}
    }
}