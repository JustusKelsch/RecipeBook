using RecipeBookAPI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBookLibrary.ViewModels {
    public class RecipesViewModel {

        private ObservableCollection<RecipeModel> recipes = new ObservableCollection<RecipeModel>();

        public void Add(RecipeModel recipe) {

            recipes.Add(recipe);

        }
        public ObservableCollection<RecipeModel> RecipesCollection {

            get { return recipes; }
            set { recipes = value; }

        }

    }
}
