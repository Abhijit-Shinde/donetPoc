using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dotnetPoc.ViewModels
{
    public class IDsViewModel
    {
        [Required]
        public List<Guid> Ids { get; set; }
    }
}