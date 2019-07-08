using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTemplateProject
{
    public class CheckingAccount : IAccount
    {
        public void CreateAccount(double initDeposit)
        {
            Console.WriteLine("Checking Acc created with initial deposit: " + initDeposit);
        }
    }
}
