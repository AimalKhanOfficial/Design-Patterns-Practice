using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTemplateProject
{
    public class SavingsAccount : IAccount
    {
        public void CreateAccount(double initDeposit)
        {
            Console.WriteLine("Savings Acc created with initial deposit: " + initDeposit);
        }
    }
}
