using Model;
using System;
using System.Collections.Generic;

namespace IBLL
{
    public interface ILoginBLL
    {
        List<usersModel> UserLogin();
    }
}
