using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTemplateProject
{
    public class AccountContext
    {
        private IAccount Account { get; set; }

        public void SetAccountType(IAccount account)
        {
            Account = account;
        }

        public void CreateAccount(double initDeposit)
        {
            Account.CreateAccount(initDeposit);
        }
    }
}
