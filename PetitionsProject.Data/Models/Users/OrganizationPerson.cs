using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetitionsProject.Data.Models.Users
{
    [Table("OrganizationPersons", Schema = "Identity")]
    public class OrganizationPerson
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int PersonId { get; set; }
        public int PositionId { get; set; }
        public bool IsActive { get; set; }

        public Organization Organization { get; set; }
        public Person Person { get; set; }
        public OrganizationPosition Positin { get; set; }
    }
}
