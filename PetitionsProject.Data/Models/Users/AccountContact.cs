using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetitionsProject.Data.Models.Users
{
    [Table("AccountContacts", Schema = "Identity")]
    public class AccountContact
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int AccountId { get; set; }
        public string Value { get; set; }
        public bool IsDefault { get; set; }
        public bool IsActive { get; set; }

        public ContactType Type { get; set; }
        public Account Account { get; set; }
    }
}
