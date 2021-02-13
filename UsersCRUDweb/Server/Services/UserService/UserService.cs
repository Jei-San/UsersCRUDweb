using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersCRUDweb.Shared;
using UsersCRUDweb.Server.Data;

namespace UsersCRUDweb.Server.Services.UserService
{
    public class UserService : IUserService
    {
        EntrevistaContext dbContext;
        public UserService(EntrevistaContext _db)
        {
            dbContext = _db;
        }
        public IEnumerable<TblUser> GetUser()
        {
            var user = dbContext.TblUsers.ToList();
            return user;
        }
        public TblUser AddUser(TblUser tblUser)
        {
            if (tblUser != null)
            {
                dbContext.TblUsers.Add(tblUser);
                dbContext.SaveChanges();
                return tblUser;
            }
            return null;
        }
        public TblUser UpdateUser(TblUser tblUser)
        {
            dbContext.Entry(tblUser).State = EntityState.Modified;
            dbContext.SaveChanges();
            return tblUser;
        }
        public TblUser DeleteUser(int id)
        {
            var tblUser = dbContext.TblUsers.FirstOrDefault(x => x.UserId == id);
            dbContext.Entry(id).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return tblUser;
        }
        public TblUser GetUserById(int id)
        {
            var tblUser = dbContext.TblUsers.FirstOrDefault(x => x.UserId == id);
            return tblUser;
        }
    }
}

