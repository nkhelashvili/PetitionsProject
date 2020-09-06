using PetitionsProject.Data.Models.Common;
using PetitionsProject.Data.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetitionsProject.Data.Models.Petitions
{
    [Table("Researchs", Schema = "Petitions")]
    public class Research
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int ResearchTypeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool AllowMultipleAnswers { get; set; }
        public bool AllowAddAnswers { get; set; }
        public bool MessageAfterVoting { get; set; }
        public bool RandomizeAnswerOrder { get; set; }
        public bool HideResults { get; set; }
        public bool HideResultsButton { get; set; }
        public string VoteButtonText { get; set; }
        public string MessageTextAfterVoting { get; set; }

        public int? GenderId { get; set; }
        public int? AgeFrom { get; set; }
        public int? AgeTo { get; set; }
        public int? RegionId { get; set; }
        public int? CityId { get; set; }
        public int? JobTypeId { get; set; }
        public bool IsActive { get; set; }

        public ResearchType ResearchType { get; set; }
        public Account Author { get; set; }
        public Gender Gender { get; set; }
        public City City { get; set; }
        public Region Region { get; set; }
        public JobType JobType { get; set; }
    }
}
