using PetitionsProject.Data.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetitionsProject.Data.Models.Users
{
    [Table("Persons", Schema = "Identity")]
    public class Person
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        [MaxLength(11)]
        public string PersonalNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int GenderId { get; set; }
        public string RegistrationAddress { get; set; }
        public int CityId { get; set; }
        public int RegionId { get; set; }
        [ForeignKey("Document")]
        public int PhotoImage { get; set; }

        public Account Account { get; set; }
        public Gender Gender { get; set; }
        public City City { get; set; }
        public Region Region { get; set; }
        public Document Document { get; set; }
    }
}
