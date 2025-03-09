using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HW17.Accounts
{
    public class SalaryAccount : IAccount
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }


        public SalaryAccount(double balance)
        {
            Balance = balance;
            CalculateInterest();
        }

        public void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}
