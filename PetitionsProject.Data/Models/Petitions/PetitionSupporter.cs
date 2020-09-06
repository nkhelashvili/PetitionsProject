using PetitionsProject.Data.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetitionsProject.Data.Models.Petitions
{
    [Table("PetitionSupporters", Schema = "Petitions")]
    public class PetitionSupporter
    {
        public int Id { get; set; }
        public int PetitionId { get; set; }
        public DateTime SigningDate { get; set; }
        public int AccountId { get; set; }

        public Petition Petition { get; set; }
        public Account Account { get; set; }
    }
}
