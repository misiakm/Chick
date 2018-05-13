﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chick.Models
{
    [Table("Dni")]
    public class Dzien
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        public int Tydzien { get; set; }

        public string Opis { get; set; }

        [ForeignKey("Dzien")]
        public virtual ICollection<PlanDnia> PlanDnia { get; set; }
    }
}