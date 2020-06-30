using System;
using System.Collections.Generic;
using IBLL;
using IDAO;
using Model;

namespace BLL
{
    public class LoginBLL : ILoginBLL
    {
        private readonly ILoginDAO loginDAO;
        public LoginBLL(ILoginDAO loginDAO)
        {
            this.loginDAO = loginDAO;
        }
        public List<usersModel> UserLogin()
        {
            return loginDAO.UserLogin();
        }
    }
}
