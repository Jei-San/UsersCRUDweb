using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersCRUDweb.Shared;

namespace UsersCRUDweb.Server.Services.UserService
{
    public interface IUserService
    {
        IEnumerable<TblUser> GetUser();
        TblUser GetUserById(int id);
        TblUser AddUser(TblUser tblUser);
        TblUser UpdateUser(TblUser tblUser);
        TblUser DeleteUser(int id);
    }
}
