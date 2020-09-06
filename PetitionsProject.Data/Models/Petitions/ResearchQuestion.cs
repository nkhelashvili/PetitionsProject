using System;
using System.Collections.Generic;
using System.Text;

namespace PetitionsProject.Data.Models.Petitions
{
    public class ResearchQuestion
    {
        public int Id { get; set; }
        public int ResearchId { get; set; }
        public string Question { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsActive { get; set; }

        public Research Research { get; set; }
    }
}
