using System;
using System.Collections.Generic;
using System.Linq;
using EFEntity;
using IDAO;
using Model;

namespace DAO
{
    public class LoginDAO:ILoginDAO
    {
        private readonly HR_DBDbContent hR_DBDbContent;
        public LoginDAO(HR_DBDbContent hR_DBDbContent)
        {
            this.hR_DBDbContent = hR_DBDbContent;
        }
        public List<usersModel> UserLogin()
        {
            List<users> list = hR_DBDbContent.Uu.ToList();
            List<usersModel> list2 = new List<usersModel>();
            foreach (users item in list)
            {
                usersModel u = new usersModel()
                {
                    User_id = item.User_id,
                    User_name = item.User_name,
                    User_password = item.User_password,
                    User_true_name = item.User_true_name
                };
                list2.Add(u);
            }
            return list2;
        }
    }
}
