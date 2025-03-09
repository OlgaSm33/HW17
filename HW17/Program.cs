using HW17.Accounts;
using System.Security.Principal;

namespace HW17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAccount account = new UsuallyAccount(200);
            Console.WriteLine(account.Balance + " " + account.Interest);

        }
    }
}
