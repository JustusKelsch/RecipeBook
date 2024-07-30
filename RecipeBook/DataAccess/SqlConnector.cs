using RecipeBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.DataAccess {
    public class SqlConnector : IDataConnection {
        public List<string> CreateDirection(List<string> directions) {
            throw new NotImplementedException();
        }

        public IngredientModel CreateIngredient(IngredientModel ingredient) {
            throw new NotImplementedException();
        }

        public RecipeModel CreateRecipe(RecipeModel recipe) {
            throw new NotImplementedException();
        }

        public RecipeModel GetRecipe(string recipeId) {
            throw new NotImplementedException();
        }

        public List<RecipeModel> GetRecipe_All() {
            throw new NotImplementedException();
        }
    }
}
