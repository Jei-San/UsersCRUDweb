using System;
using System.Collections.Generic;

#nullable disable

namespace UsersCRUDweb.Shared
{
    public partial class TblUserProfession
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProfessionId { get; set; }

        public virtual TblProfession Profession { get; set; }
        public virtual TblUser User { get; set; }
    }
}
