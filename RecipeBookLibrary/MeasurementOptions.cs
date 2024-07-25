using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBookLibrary {
    public class MeasurementOptions {

        public List<string> measurementsOptions = new List<string>();

        public MeasurementOptions() {

            measurementsOptions.Add("Cup(s)");
            measurementsOptions.Add("Tbsp(s)");
            measurementsOptions.Add("Tsp(s)");
            measurementsOptions.Add("oz");
            measurementsOptions.Add("gram(s)");

        }

    }
}
