using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class ContactModel
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string phoneNumber { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string message { get; set; }

    }
}
