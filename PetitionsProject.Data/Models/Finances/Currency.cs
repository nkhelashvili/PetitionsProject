﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetitionsProject.Data.Models.Finances
{
    [Table("Currencies", Schema = "Finances")]
    public class Currency
    {
        public int Id { get; set; }
        [MaxLength(5)]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

    }
}
