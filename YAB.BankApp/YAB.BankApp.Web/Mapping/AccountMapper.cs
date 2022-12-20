using YAB.BankApp.Web.Data.Entities;
using YAB.BankApp.Web.Models;

namespace YAB.BankApp.Web.Mapping
{
    public class AccountMapper: IAccountMapper
    {
        public Account Map(AccountCreateModel model)
        {
            return new Account
            {
                AccountNumber = model.AccountNumber,
                ApplicationUserId = model.ApplicationUserId,
                Balance = model.Balance
            };   
        }
    }
}
