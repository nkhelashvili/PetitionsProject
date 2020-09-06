using PetitionsProject.Data.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetitionsProject.Data.Models.Petitions
{
    [Table("ResearchQuestionAnswerResults", Schema = "Petitions")]
    public class ResearchQuestionAnswerResult
    {
        public int Id { get; set; }
        public int AnswerAuthorId { get; set; }
        public int ResearchQuestionId { get; set; }
        public int ResearchQuestionAnswerId { get; set; }
        public string TextAnswer { get; set; }
        public DateTime AnswerDate { get; set; }

        public Account AnswerAuthor { get; set; }
        public ResearchQuestion ResearchQuestion { get; set; }
        public ResearchQuestionAnswer ResearchQuestionAnswer { get; set; }
    }
}
