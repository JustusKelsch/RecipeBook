using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RecipeBookLibrary.Models {
    public class RecipeModel {

        public int Id { get; set; }
        public string RecipeName { get; set; }
        public ObservableCollection<IngredientModel> Ingredients { get; set; } = new ObservableCollection<IngredientModel>();
        public ObservableCollection<string> Directions { get; set; } = new ObservableCollection<string>();

        public ObservableCollection<IngredientModel> IngredientCollection {

            get { return Ingredients; }
            set { Ingredients = value; }

        }

        public ObservableCollection<string> DirectionsCollection {

            get { return Directions; }
            set { Directions = value; }

        }
    }
}
