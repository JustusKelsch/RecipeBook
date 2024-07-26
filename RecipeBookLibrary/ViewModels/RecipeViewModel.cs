﻿using RecipeBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBookLibrary.ViewModels {
    public class RecipeViewModel {

        private List<RecipeModel> recipes = new List<RecipeModel>();

        public void Add(RecipeModel recipe) {

            recipes.Add(recipe);

        }

        public List<RecipeModel> RecipeCollection {

            get { return recipes; }
            set { recipes = value; }

        }

    }

}
