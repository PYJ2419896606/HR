using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IBLL;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace HR.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginBLL loginBLL;
        public LoginController(ILoginBLL loginBLL)
        {
            this.loginBLL = loginBLL;
        }
        public IActionResult Index(usersModel uu)
        {
                List<usersModel> list = loginBLL.UserLogin().Where(e => e.User_name == uu.User_name && e.User_password == uu.User_password).ToList();
                return View();
        }
    }
}
