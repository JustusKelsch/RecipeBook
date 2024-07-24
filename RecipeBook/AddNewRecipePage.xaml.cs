
using RecipeBookLibrary.Models;
using RecipeBookLibrary.ViewModels;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace RecipeBook;

public partial class AddNewRecipePage : ContentPage {

    public RecipeModel recipe = new RecipeModel();
    public AddNewRecipePage()
	{
		InitializeComponent();
        BindingContext = recipe;

    }

    private void AddIngredientButton_Clicked(object sender, EventArgs e) {

        recipe.Ingredients.Add(IngredientsEntry.Text);
        IngredientsEntry.Text = string.Empty;

    }

    private void AddPrepInstructionsButton_Clicked(object sender, EventArgs e) {

        recipe.PreparationInstructions.Add(PrepInstructionsEntry.Text);
        PrepInstructionsEntry.Text = string.Empty;

    }
}