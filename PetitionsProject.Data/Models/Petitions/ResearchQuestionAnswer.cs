using PetitionsProject.Data.Models.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetitionsProject.Data.Models.Petitions
{
    public class ResearchQuestionAnswer
    {
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public int ResearchQuestionId { get; set; }
        public string Answer { get; set; }
        public int AddedByUserId { get; set; }

        public ResearchQuestion ResearchQuestion { get; set; }
        public Account AddedByUser { get; set; }
    }
}
