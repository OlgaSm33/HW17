using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HW17.Accounts
{
    public class UsuallyAccount : IAccount
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public UsuallyAccount(double balance)
        {
            Balance = balance;
            CalculateInterest();
        }

        public void CalculateInterest()
        {
            Interest = Balance * 0.4;
            if (Balance < 1000)
                Interest -= Balance * 0.2;
            if (Balance >= 1000)
                Interest -= Balance * 0.4;
        }
    }
}
