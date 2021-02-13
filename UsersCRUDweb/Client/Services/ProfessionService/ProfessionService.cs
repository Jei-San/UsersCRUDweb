using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersCRUDweb.Shared;

namespace UsersCRUDweb.Client.Services.ProfessionService
{
    public class ProfessionService : IProfessionService
    {
        EntrevistaContext dbContext;
        public ProfessionService(EntrevistaContext _db)
        {
            dbContext = _db;
        }
        public IEnumerable<TblProfession> GetProfession()
        {
            var profession = dbContext.TblProfessions.ToList();
            return profession;
        }
    }
}
