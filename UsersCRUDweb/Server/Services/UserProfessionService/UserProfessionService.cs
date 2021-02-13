using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersCRUDweb.Server.Data;
using UsersCRUDweb.Shared;

namespace UsersCRUDweb.Server.Services.UserProfessionService
{
    public class UserProfessionService : IUserProfessionService
    {
        EntrevistaContext dbContext;
        public UserProfessionService(EntrevistaContext _db)
        {
            dbContext = _db;
        }
        public TblUserProfession AddUserProfession(TblUserProfession tblUserProfession)
        {
            if (tblUserProfession != null)
            {
                dbContext.TblUserProfessions.Add(tblUserProfession);
                dbContext.SaveChanges();
                return tblUserProfession;
            }
            return null;
        }
    }
}
