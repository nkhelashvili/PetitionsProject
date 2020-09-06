using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetitionsProject.Data.Models.Users
{
    [Table("AccountProvider", Schema = "Identity")]
    public class AccountProvider
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int ProviderId { get; set; }
        public bool IsActive { get; set; }

        public IdentityProvider Provider { get; set; }
        public Account Account { get; set; }
    }
}
