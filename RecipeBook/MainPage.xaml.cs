using RecipeBookLibrary;
using RecipeBookAPI.Models;
using RecipeBookLibrary.ViewModels;
using System;
using System.Collections.ObjectModel;
using static System.Net.WebRequestMethods;

namespace RecipeBook {
    public partial class MainPage : ContentPage{

        private RecipesViewModel recipes = new RecipesViewModel();
        public MainPage() {
            InitializeComponent();
            recipes.Add(new RecipeModel {
                RecipeName = "Test",
                Ingredients = [new IngredientModel {
                    Amount = 1,
                    Measurement = "Cup",
                    Ingredient = "Flour"
                }],
                Directions = [new DirectionModel {
                    Direction = "Cook"
                }],
            });
            // TODO - Grab all recipes from a DataBase
            BindingContext = recipes;
        }

        private async void AddNewRecipeButton_Clicked(object sender, EventArgs e) {

            AddNewRecipePage recipePage = new AddNewRecipePage();
            await Navigation.PushAsync(recipePage);

        }
    }
}
