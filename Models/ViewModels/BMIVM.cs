using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BMIAndHealth.Models.ViewModels {
    public class BMIVM { 

        public string Id { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Value Must be Positive")]
        public double Height { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Value Must be Positive")]
        public double Weight { get; set; }


    }
}
