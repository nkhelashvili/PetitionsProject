using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetitionsProject.Data.Models.Users
{
    [Table("Claims", Schema = "Identity")]
    public class Claim
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }

        public Claim Parent { get; set; }
    }
}
