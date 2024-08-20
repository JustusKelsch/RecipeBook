using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBookAPI.Models {
    public class RecipeModel {

        public int Id { get; set; }
        public string RecipeName { get; set; }
        public List<IngredientModel> Ingredients { get; set; } = new List<IngredientModel>();
        public List<DirectionModel> Directions { get; set; } = new List<DirectionModel>();
    }
}
