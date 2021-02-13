using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersCRUDweb.Server.Data;
using UsersCRUDweb.Server.Services.UserProfessionService;
using UsersCRUDweb.Shared;

namespace UsersCRUDweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfessionController : ControllerBase
    {
        private readonly IUserProfessionService userProfessionService;
        public UserProfessionController(IUserProfessionService userProfession)
        {
            userProfessionService = userProfession;
        }
        EntrevistaContext EC = new EntrevistaContext();
        [HttpGet]
        [Route("[action]")]
        public object GetUserProfession()
        {
            using (EC)
            {
                var result = (from up in EC.TblUserProfessions
                              join p in EC.TblProfessions on up.ProfessionId equals p.ProfessionId
                              join u in EC.TblUsers on up.UserId equals u.UserId
                              select new
                              {
                                  FirstName = u.FirstName,
                                  LastName = u.LastName,
                                  Profession = p.ProfessionName,
                              }).ToList();

                string json = Newtonsoft.Json.JsonConvert.SerializeObject(result, Newtonsoft.Json.Formatting.Indented);
                return result;
            }
        }
        [HttpPost]
        [Route("[action]")]
        public TblUserProfession AddUserProfession(TblUserProfession tblUserProfession)
        {
            return userProfessionService.AddUserProfession(tblUserProfession);
        }
    }
}
