﻿using System.ComponentModel.DataAnnotations;

namespace MyAppAPI.Model
{
    public class ProcurementFilter
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)] // Adjust the max length as needed
        public string Name { get; set; }
    }
}
