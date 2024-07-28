using RecipeBookLibrary;
using RecipeBookLibrary.Models;
using RecipeBookLibrary.ViewModels;

namespace RecipeBook {
    public partial class MainPage : ContentPage{

        RecipeViewModel recipes = new RecipeViewModel();

        public MainPage() {
            InitializeComponent();
            // TODO - Grab all recipes from a DataBase
            BindingContext = recipes;
        }

        private void AddNewRecipeButton_Clicked(object sender, EventArgs e) {

            AddNewRecipePage recipePage = new AddNewRecipePage();
            Navigation.PushAsync(recipePage);

        }
    }
}
