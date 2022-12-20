using YAB.BankApp.Web.Data.Entities;
using YAB.BankApp.Web.Models;

namespace YAB.BankApp.Web.Mapping
{
    public interface IAccountMapper
    {
        public Account Map(AccountCreateModel model);
    }
}
