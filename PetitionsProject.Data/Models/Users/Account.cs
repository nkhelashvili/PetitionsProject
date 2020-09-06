using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetitionsProject.Data.Models.Users
{
    [Table("Accounts", Schema = "Identity")]
    public class Account
    {
        public int Id { get; set; }
        [ForeignKey("AccountType")]
        public int TypeId { get; set; }
        public int AccountStateId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AvatarImage { get; set; }

        public AccountType AccountType { get; set; }
        public AccountState AccountState { get; set; }
    }
}
