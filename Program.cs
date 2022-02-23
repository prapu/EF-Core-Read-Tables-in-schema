using System;
using System.Linq;

namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading Account details!");
            using(var DB= new AppContext())
            {
                var account = DB.Account.Where(x => x.AccountID == 1).FirstOrDefault();
                Console.WriteLine($"Account number : {account.AccountNumber} And Account Name : {account.AccountName}");
            }
        }
    }
}
