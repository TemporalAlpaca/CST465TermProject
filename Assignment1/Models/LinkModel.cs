using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class LinkModel
    {
        [Required]
        public string linkAddress { get; set; }

        [Required]
        public string linkName { get; set; }

        [Required]
        public int pLevel { get; set; }

        
    }
}
