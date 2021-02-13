using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersCRUDweb.Server.Data;
using UsersCRUDweb.Server.Services.ProfessionService;
using UsersCRUDweb.Shared;

namespace UsersCRUDweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessionController : ControllerBase
    {
        private readonly EntrevistaContext _context;

        public ProfessionController(EntrevistaContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Professions")]
        public List<TblProfession> GetUser()
        {
            List<TblProfession> professions = _context.TblProfessions.ToList();
            List<TblProfession> professionList = new List<TblProfession>();

            foreach (var u in professions)
            {
                professionList.Add(new TblProfession(u.ProfessionName));

            }
            return professionList;
        }
    }
}
