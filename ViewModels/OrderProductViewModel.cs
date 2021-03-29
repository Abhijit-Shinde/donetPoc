using System;
using System.ComponentModel.DataAnnotations;

namespace dotnetPoc.ViewModels
{
    public class OrderProductViewModel
    {
        [Required]
        public Guid ProductID { get; set; }

        [Required]
        public int Quantity { get; set; }

    }
}