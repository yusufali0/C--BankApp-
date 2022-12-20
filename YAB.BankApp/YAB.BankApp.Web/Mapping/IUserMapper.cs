using System.Collections.Generic;
using YAB.BankApp.Web.Data.Entities;
using YAB.BankApp.Web.Models;

namespace YAB.BankApp.Web.Mapping
{
    public interface IUserMapper
    {
        List<UserListModel> MapToListOfUserList(List<ApplicationUser> users);
        UserListModel MapToUserList(ApplicationUser user);
    }
}
