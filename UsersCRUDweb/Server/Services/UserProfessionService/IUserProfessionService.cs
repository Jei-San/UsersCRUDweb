using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersCRUDweb.Shared;

namespace UsersCRUDweb.Server.Services.UserProfessionService
{
    public interface IUserProfessionService
    {
        TblUserProfession AddUserProfession(TblUserProfession tblUserProfession);
    }
}
