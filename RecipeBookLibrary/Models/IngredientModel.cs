using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBookAPI.Models {
    public class IngredientModel {
        public int Id { get; set; }
        public double Amount { get; set; }
        public string Measurement { get; set; }
        public string Ingredient { get; set; }

    }
}
