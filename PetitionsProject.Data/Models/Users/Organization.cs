using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetitionsProject.Data.Models.Users
{
    [Table("Organizations", Schema = "Identity")]
    public class Organization
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        [MaxLength(9)]
        public string IdentificationNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IsActive { get; set; }
        
        public Account Account { get; set; }
    }
}
