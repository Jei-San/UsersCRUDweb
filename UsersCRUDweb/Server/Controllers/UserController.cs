using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersCRUDweb.Client.Shared;
using UsersCRUDweb.Server.Data;
using UsersCRUDweb.Server.Services.UserService;
using UsersCRUDweb.Shared;

namespace UsersCRUDweb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly EntrevistaContext _context;

        public UserController(EntrevistaContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Users")]
        public List<TblUser> GetUser()
        {
            List<TblUser> users = _context.TblUsers.ToList();
            List<TblUser> userList = new List<TblUser>();

            foreach(var u in users)
            {
                userList.Add(new TblUser(u.UserId, u.FirstName, u.LastName));
            }
            return userList;
        }
        [HttpPost]
        [Route("AddUsers")]
        public TblUser AddUser(TblUser tblUser)
        {
            if (tblUser != null)
            {
                _context.TblUsers.Add(tblUser);
                _context.SaveChanges();
                return tblUser;
            }
            return null;
        }
        [HttpPut]
        [Route("DeleteUsers")]
        public TblUser DeleteUser(TblUser tblUser)
        {
            _context.Entry(tblUser).State = EntityState.Deleted;
            _context.SaveChanges();
            return tblUser;
        }
        [HttpPut]
        [Route("EditUsers")]
        public TblUser PutUser(TblUser tblUser)
        {
            _context.Entry(tblUser).State = EntityState.Modified;
            _context.SaveChangesAsync();
            return tblUser;
        }
    }
}
