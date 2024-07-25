
using RecipeBookLibrary.Models;
using RecipeBookLibrary.ViewModels;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace RecipeBook;

public partial class AddNewRecipePage : ContentPage {

    private RecipeModel recipe = new RecipeModel();
    private string measurement = String.Empty;
    public AddNewRecipePage()
	{
		InitializeComponent();
        BindingContext = recipe;

    }

    private void AddIngredientButton_Clicked(object sender, EventArgs e) {

        if (string.IsNullOrEmpty(measurement)) {

            DisplayAlert("No Measurement Type", "Please select a Measurement Type.", "OK");

        }
        else if (string.IsNullOrWhiteSpace(IngredientsEntry.Text)) {

            DisplayAlert("No Ingredient Entered", "Please enter an ingredient.", "OK");

        }
        else {

            recipe.Ingredients.Add(measurement + " " + IngredientsEntry.Text);
            IngredientsEntry.Text = string.Empty;

        }

    }

    private void AddDirectionsButton_Clicked(object sender, EventArgs e) {

        if (string.IsNullOrWhiteSpace(DirectionsEntry.Text)) {

            DisplayAlert("No Direction Entered", "Please enter a direction.", "OK");

        }
        else {

            recipe.Directions.Add(DirectionsEntry.Text);
            DirectionsEntry.Text = string.Empty;

        }

    }

    private void MeasurmentPicker_SelectedIndexChanged(object sender, EventArgs e) {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;
        measurement = picker.Items[selectedIndex];
    }
}