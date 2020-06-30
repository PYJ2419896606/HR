using Model;
using System;
using System.Collections.Generic;

namespace IDAO
{
    public interface ILoginDAO
    {
        List<usersModel> UserLogin();
    }
}
