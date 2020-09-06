using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetitionsProject.Data.Models.Users
{
    [Table("AccountRoles", Schema ="Identity")]
    public class AccountRole
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int RoleId { get; set; }
        public bool IsActive { get; set; }

        public Role Role { get; set; }
        public Account Account { get; set; }
    }
}
