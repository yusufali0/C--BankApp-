using System.Collections.Generic;
using YAB.BankApp.Web.Data.Entities;

namespace YAB.BankApp.Web.Data.Interfaces
{
    public interface IApplicationUserRepository
    {
        List<ApplicationUser> GetAll();
        ApplicationUser GetById(int id);

    }
}
