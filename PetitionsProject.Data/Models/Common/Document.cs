using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetitionsProject.Data.Models.Common
{
    [Table("Documents")]
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime UploadDate { get; set; }
        public long Size { get; set; }
        public byte[] FileData { get; set; }
        public bool IsActive { get; set; }
    }
}
