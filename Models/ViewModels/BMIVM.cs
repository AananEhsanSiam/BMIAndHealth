using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BMIAndHealth.Models.ViewModels {
    public class BMIVM { 
        [Required]
        [Display(Name = "Height (in cm)")]
        [Range(0, double.MaxValue, ErrorMessage = "Value Must be Positive")]
        public double Height { get; set; }
        [Required]
        [Display(Name = "Weight (in kgs)")]
        [Range(0, double.MaxValue, ErrorMessage = "Value Must be Positive")]
        public double Weight { get; set; }

        public IEnumerable<UserHistory> userHistories { get; set; }


    }
}
