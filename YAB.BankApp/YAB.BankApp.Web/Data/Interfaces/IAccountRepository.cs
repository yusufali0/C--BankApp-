using YAB.BankApp.Web.Data.Entities;

namespace YAB.BankApp.Web.Data.Interfaces
{
    public interface IAccountRepository
    {
        void Create(Account account);
    }
}
