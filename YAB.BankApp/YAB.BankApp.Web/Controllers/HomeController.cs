using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using YAB.BankApp.Web.Data.Context;
using YAB.BankApp.Web.Data.Entities;
using YAB.BankApp.Web.Data.Interfaces;
using YAB.BankApp.Web.Data.Repositories;
using YAB.BankApp.Web.Data.UnitOfWork;
using YAB.BankApp.Web.Mapping;
using YAB.BankApp.Web.Models;

namespace YAB.BankApp.Web.Controllers
{
    public class HomeController : Controller
    {
        
      //  private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IUserMapper _userMapper;
        private readonly IUow _uow;

        public HomeController(/* IApplicationUserRepository applicationUserRepository,*/ IUserMapper userMapper, IUow uow)
        {

            // _applicationUserRepository = applicationUserRepository;
            _userMapper = userMapper;
            _uow = uow;
        }

        public IActionResult Index()
        {
            return View(_userMapper.MapToListOfUserList(_uow.GetRepository<ApplicationUser>().GetAll()));
        }


   
    }
}
