using PetitionsProject.Data.Models.Common;
using PetitionsProject.Data.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PetitionsProject.Data.Models.Petitions
{
    [Table("Petitions", Schema = "Petitions")]
    public class Petition
    {
        public int Id { get; set; }
        public int CorelationId { get; set; }
        public int TransactionId { get; set; }
        [MaxLength(500)]
        public string Title { get; set; }
        public string Content { get; set; }
        public int DesiredVotesCount { get; set; }
        public int DueDays { get; set; }
        public int RegionId { get; set; }
        public int CityId { get; set; }

        public Transaction Transaction { get; set; }
        public Region Region { get; set; }
        public City City { get; set; }
        
    }
}
