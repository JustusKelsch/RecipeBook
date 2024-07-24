using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBookLibrary.ViewModels {
    public class IngredientViewModel {

        private List<string> ingredients = new List<string>();

        public IngredientViewModel() { 
        


        }

        public List<string> IngredientCollection {

            get { return ingredients; }
            set { ingredients = value; }
        
        }
    }
}
