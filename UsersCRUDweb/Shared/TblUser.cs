using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace UsersCRUDweb.Shared
{
    public partial class TblUser
    {
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public TblUser()
        {
            TblUserProfessions = new HashSet<TblUserProfession>();
        }
        public TblUser(int userId, string firstName, string lastName)
        {
            this.UserId = userId;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public virtual ICollection<TblUserProfession> TblUserProfessions { get; set; }
    }
}
