using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBookLibrary.Models {
    public class RecipeModel {

        public string RecipeName { get; set; }
        public ObservableCollection<string> Ingredients { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> PreparationInstructions { get; set; } = new ObservableCollection<string>();

        public ObservableCollection<string> IngredientCollection {

            get { return Ingredients; }
            set { Ingredients = value; }

        }

        public ObservableCollection<string> PreparationInstructionsCollection {

            get { return PreparationInstructions; }
            set { PreparationInstructions = value; }

        }
    }
}
