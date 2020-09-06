using PetitionsProject.Data.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetitionsProject.Data.Models.Petitions
{
    [Table("Transactions", Schema = "Petitions")]
    public class Transaction
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int TypeId { get; set; }
        public int StateId { get; set; }
        public string TxId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string SignedHash { get; set; }
        
        public Account Account { get; set; }
        public TransactionType Type { get; set; }
        public TransactionState State { get; set; }
    }
}
