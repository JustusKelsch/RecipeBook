using RecipeBookAPI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBookLibrary.ViewModels {
    public class RecipeViewModel {

        private RecipeModel recipe = new RecipeModel();

        public string RecipeName {

            get { return recipe.RecipeName; }
            set { recipe.RecipeName = value; }

        }

        public ObservableCollection<IngredientModel> IngredientsCollection {

            get { return recipe.Ingredients; }
            set { recipe.Ingredients = value; }

        }

        public ObservableCollection<string> DirectionsCollection {

            get { return recipe.Directions; }
            set { recipe.Directions = value; }

        }

    }

}
