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
            var accContext = new AccountContext();
            accContext.SetAccountType(new SavingsAccount());
            accContext.CreateAccount(1000);
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