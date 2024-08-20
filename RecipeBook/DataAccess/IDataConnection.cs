using RecipeBookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.DataAccess {
    public interface IDataConnection {

        IngredientModel CreateIngredient(IngredientModel ingredient);
        RecipeModel CreateRecipe(RecipeModel recipe);
        List<string> CreateDirection(List<string> directions);
        List<RecipeModel> GetRecipe_All();
        RecipeModel GetRecipe(string recipeId);

    }
}
