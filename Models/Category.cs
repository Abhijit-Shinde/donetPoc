using System;
using System.ComponentModel.DataAnnotations;

namespace dotnetPoc.Models
{
    public class Category
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public String ProductCategory { get; set; }

    }
}