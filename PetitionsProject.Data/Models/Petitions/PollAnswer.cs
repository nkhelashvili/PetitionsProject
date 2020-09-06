using System;
using System.Collections.Generic;
using System.Text;

namespace PetitionsProject.Data.Models.Petitions
{
    public class PollAnswer
    {
        public int Id { get; set; }
        public int PollId { get; set; }
        public string Answer { get; set; }
        public bool IsActive { get; set; }

        public Poll Poll { get; set; }
    }
}
