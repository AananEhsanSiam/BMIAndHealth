using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BMIAndHealth.Models.ViewModels {
    public class WNVM {
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Value Must be Positive")]
        public int Age { get; set; }
        [Required]
        [Display(Name = "Weight (in kgs)")]
        [Range(0, double.MaxValue, ErrorMessage = "Value Must be Positive")]
        public double Weight { get; set; }
    }
}
