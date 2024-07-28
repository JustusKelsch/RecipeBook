
using RecipeBookLibrary;
using RecipeBookLibrary.Models;
using RecipeBookLibrary.ViewModels;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace RecipeBook;

public partial class AddNewRecipePage : ContentPage {

    private RecipeModel recipe = new RecipeModel();
    private string measurement = string.Empty;

    public AddNewRecipePage()
	{
		InitializeComponent();
        BindingContext = recipe;

    }

    private void AddIngredientButton_Clicked(object sender, EventArgs e) {

        bool isNum = int.TryParse(IngredientsAmountEntry.Text, out int result);
        if (!isNum || string.IsNullOrWhiteSpace(IngredientsAmountEntry.Text)) {

            DisplayAlert("Amount must be a number", "Please enter a number.", "OK");

        }
        else if (string.IsNullOrWhiteSpace(measurement)) {

            DisplayAlert("No Measurement Type", "Please select a Measurement Type.", "OK");

        }
        else if (string.IsNullOrWhiteSpace(IngredientsEntry.Text)) {

            DisplayAlert("No Ingredient Entered", "Please enter an ingredient.", "OK");

        }
        else {

            string formattedMeasurement = measurement.Substring(0, measurement.Length - 3);
            if (result == 1) {
                recipe.Ingredients.Add(new IngredientModel {
                    Amount = result,
                    Measurement = formattedMeasurement,
                    Ingredient = IngredientsEntry.Text

                });

            }
            else {
                recipe.Ingredients.Add(new IngredientModel {
                    Amount = result,
                    Measurement = $"{formattedMeasurement}s",
                    Ingredient = IngredientsEntry.Text

                });

            }

            IngredientsEntry.Text = string.Empty;
            IngredientsAmountEntry.Text = string.Empty;
            

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

    private void AddRecipeButton_Clicked(object sender, EventArgs e) {

        if (string.IsNullOrWhiteSpace(RecipeNameEntry.Text)) {

            DisplayAlert("No Recipe Name", "Please enter a Recipe Name.", "OK");

        }
        else if (recipe.Ingredients.Count == 0) {

            DisplayAlert("No Ingredients", "Please enter some Ingredients.", "OK");

        }
        else if (recipe.Directions.Count == 0) {

            DisplayAlert("No Directions", "Please enter some Directions.", "OK");

        }
        else {

            recipe.RecipeName = RecipeNameEntry.Text;
            // TODO - Add new recipe to a DataBase
            Navigation.PopAsync();

        }

    }

    private async void CancelAddRecipeButton_Clicked(object sender, EventArgs e) {

        bool answer = await DisplayAlert("Are you sure?", "Are you sure you want to cancel? Progress for this recipe will not be saved.", "Yes", "No");

        if (answer) {
            await Navigation.PopAsync();
        }

    }

}