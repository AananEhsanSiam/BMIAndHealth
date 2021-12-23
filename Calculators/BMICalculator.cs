using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMIAndHealth.Calculators {
    public static class BMICalculator {  
        public static double Calculate (double height, double weight) {
            height = height / 100;
            double result = weight / (height * height);
            result = Math.Round(result, 1);
            return result;
        }
    }
}
