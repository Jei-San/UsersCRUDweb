using System;
using System.Collections.Generic;

#nullable disable

namespace UsersCRUDweb.Shared
{
    public partial class TblProfession
    {
        public TblProfession()
        {
            TblUserProfessions = new HashSet<TblUserProfession>();
        }

        public int ProfessionId { get; set; }
        public string ProfessionName { get; set; }
        public TblProfession( string professionName)
        {
            this.ProfessionName = professionName;
        }
        public virtual ICollection<TblUserProfession> TblUserProfessions { get; set; }
    }
}
