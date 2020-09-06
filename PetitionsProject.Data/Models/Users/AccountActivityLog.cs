using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetitionsProject.Data.Models.Users
{
    [Table("AccountActivityLogs", Schema = "Identity")]
    public class AccountActivityLog
    {
        public int Id { get; set; }
        public int AccountActivityId { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public string StackTrace { get; set; }

        public AccountActivity AccountActivity { get; set; }
    }
}
