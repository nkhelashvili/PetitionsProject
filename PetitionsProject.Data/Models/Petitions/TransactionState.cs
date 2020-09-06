using System.ComponentModel.DataAnnotations.Schema;

namespace PetitionsProject.Data.Models.Petitions
{
    [Table("TransactionStates", Schema = "Petitions")]
    public class TransactionState
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}