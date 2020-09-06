using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetitionsProject.Data.Models.Users
{
    [Table("RoleClaims", Schema = "Identity")]
    public class RoleClaim
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int ClaimId { get; set; }
        public bool IsActive { get; set; }
        
        public Claim Claim { get; set; }
        public Role Role { get; set; }
    }
}
