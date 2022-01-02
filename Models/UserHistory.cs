using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BMIAndHealth.Models {
    public class UserHistory {
        public int Id { get; set; }

        public string UserId { get; set; }

        public double WaterNeeds { get; set; }

        public double BMI { get; set; }

        public DateTime Time { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
