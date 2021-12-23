using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BMIAndHealth.Models {
    public class ApplicationUser : IdentityUser {
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Height must be greater than 0")]
        public double Height { get; set; }

        [Required]
        public char Gender { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
    }
}
