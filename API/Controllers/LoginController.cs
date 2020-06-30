using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IBLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginBLL loginBLL;
        public LoginController(ILoginBLL loginBLL)
        {
            this.loginBLL = loginBLL;
        }
        [HttpGet]
        public List<usersModel> LoginIndex()
        {
            List<usersModel> list = loginBLL.UserLogin();
            return list;
        }
    }
}
