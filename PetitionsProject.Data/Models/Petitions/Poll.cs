using PetitionsProject.Data.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetitionsProject.Data.Models.Petitions
{
    [Table("Polls", Schema = "Petitions")]
    public class Poll
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ValidityDateFrom { get; set; }
        public DateTime ValidityDateTo { get; set; }
        public int CreatedByAccountId { get; set; }
        public int StateId { get; set; }
        public bool IsActive { get; set; }

        public Account CreatedByAccount { get; set; }
        public PollState State { get; set; }
        public ICollection<PollAnswer> PollAnswers { get; set; }
    }
}
