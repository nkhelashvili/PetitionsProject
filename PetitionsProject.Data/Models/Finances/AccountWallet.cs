using PetitionsProject.Data.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetitionsProject.Data.Models.Finances
{
    [Table("AccountWallets", Schema = "Finances")]
    public class AccountWallet
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int CurrencyId { get; set; }
        public string Address { get; set; }
        public decimal Balance { get; set; }
        public bool IsActive { get; set; }

        public Account Account { get; set; }
        public Currency Currency { get; set; }
    }
}
