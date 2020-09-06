using PetitionsProject.Data.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetitionsProject.Data.Models.Petitions
{

    [Table("PollAnswerResults", Schema ="Petitions")]
    public class PollAnswerResult
    {
        public int Id { get; set; }
        public DateTime AnswerSelectionDate { get; set; }
        public int PollAnswerId { get; set; }
        public int AccountId { get; set; }
        public bool IsActive { get; set; }

        public PollAnswer PollAnswer { get; set; }
        public Account Account { get; set; }
    }
}
