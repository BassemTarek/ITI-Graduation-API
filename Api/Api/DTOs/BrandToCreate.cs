﻿using System.ComponentModel.DataAnnotations;

namespace Api.DTOs
{
    public class BrandToCreate
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
