using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMIAndHealth.Calculators {
    public static class BMICalculator {  
        public static double Calculate (double height, double weight) {
            double result = weight / (height * height);
            result = Math.Round(result, 2);
            return result;
        }
    }
}
