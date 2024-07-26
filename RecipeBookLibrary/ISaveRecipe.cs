using RecipeBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBookLibrary {
    public interface ISaveRecipe {

        void SaveRecipe(RecipeModel recipe);

    }
}
