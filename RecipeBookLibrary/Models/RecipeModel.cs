using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBookLibrary.Models {
    public class RecipeModel {

        public string RecipeName { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();
        public List<string> PreparationInstructions { get; set; } = new List<string>();

    }
}
