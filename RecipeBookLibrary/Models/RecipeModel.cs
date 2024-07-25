using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RecipeBookLibrary.Models {
    public class RecipeModel {

        MeasurementOptions measurements = new MeasurementOptions();
        public string RecipeName { get; set; }
        public ObservableCollection<string> Ingredients { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> Directions { get; set; } = new ObservableCollection<string>();

        public ObservableCollection<string> IngredientCollection {

            get { return Ingredients; }
            set { Ingredients = value; }

        }

        public ObservableCollection<string> DirectionsCollection {

            get { return Directions; }
            set { Directions = value; }

        }

        public List<string> MeasurementCollection {

            get { return measurements.measurementsOptions; }

        }
    }
}
