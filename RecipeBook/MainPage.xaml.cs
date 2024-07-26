using RecipeBookLibrary;
using RecipeBookLibrary.Models;
using RecipeBookLibrary.ViewModels;

namespace RecipeBook {
    public partial class MainPage : ContentPage, ISaveRecipe {

        RecipeViewModel recipes = new RecipeViewModel();

        public MainPage() {
            InitializeComponent();
            BindingContext = recipes;
        }

        public void SaveRecipe(RecipeModel recipe) {
            recipes.Add(recipe);
        }

        private void AddNewRecipeButton_Clicked(object sender, EventArgs e) {

            AddNewRecipePage recipePage = new AddNewRecipePage(this);
            App.Current.MainPage = recipePage;

        }
    }
}
