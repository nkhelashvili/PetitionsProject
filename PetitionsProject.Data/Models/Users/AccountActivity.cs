using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetitionsProject.Data.Models.Users
{
    [Table("AccountActivities", Schema = "Identity")]
    public class AccountActivity
    {
        public int Id { get; set; }
        public int ActivityTypeId { get; set; }
        public int AccountId { get; set; }
        public string ClientHost { get; set; }
        public string ClientIp { get; set; }
        public string ClientDevice { get; set; }
        public DateTime CreateDate { get; set; }
        public int ActivityStateId { get; set; }

        public Account Account { get; set; }
        public ActivityType ActivityType { get; set; }
        public ActivityState ActivityState { get; set; }
    }
}