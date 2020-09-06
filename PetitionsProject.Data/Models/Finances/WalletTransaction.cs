using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetitionsProject.Data.Models.Finances
{
    [Table("WalletTransactions", Schema = "Finances")]
    public class WalletTransaction
    {
        public int Id { get; set; }
        public int TransactionId { get; set; }
        public int AccountWalletId { get; set; }
        public int DirectionId { get; set; }
        public decimal Amount { get; set; }

        public WalletTransaction Transaction { get; set; }
        public AccountWallet AccountWallet { get; set; }
        public TransactionDirection Direction { get; set; }
    }
}
