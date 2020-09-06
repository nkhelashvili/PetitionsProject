using PetitionsProject.Data.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetitionsProject.Data.Models.Finances
{
    [Table("CurrencyOperationGrants", Schema = "Finances")]
    public class CurrencyOperationGrant
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int CurrencyOperationId { get; set; }
        public bool Grant { get; set; }

        public Account Account { get; set; }
        public CurrencyOperation CurrencyOperation { get; set; }
    }
}
