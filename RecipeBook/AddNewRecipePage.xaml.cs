
using RecipeBookLibrary;
using RecipeBookLibrary.Models;
using RecipeBookLibrary.ViewModels;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace RecipeBook;

public partial class AddNewRecipePage : ContentPage {

    private RecipeViewModel recipe = new RecipeViewModel();
    
    public AddNewRecipePage()
	{
		InitializeComponent();
        BindingContext = recipe;

    }

    private void AddIngredientButton_Clicked(object sender, EventArgs e) {

        string measurement = (string)MeasurmentPicker.SelectedItem;
        if (string.IsNullOrWhiteSpace((string)AmountPicker.SelectedItem)) {

            DisplayAlert("Amount Not Selected", "Please select an amount.", "OK");

        }
        else if (string.IsNullOrWhiteSpace(measurement)) {

            DisplayAlert("No Measurement Type", "Please select a Measurement Type.", "OK");

        }
        else if (string.IsNullOrWhiteSpace(IngredientsEntry.Text)) {

            DisplayAlert("No Ingredient Entered", "Please enter an ingredient.", "OK");

        }
        else {

            string formattedMeasurement = measurement.Substring(0, measurement.Length -3);
            double numAmount = NumConverter((string)AmountPicker.SelectedItem);
            if (numAmount <= 1) {
                recipe.IngredientsCollection.Add(new IngredientModel {
                    Amount = numAmount,
                    Measurement = formattedMeasurement,
                    Ingredient = IngredientsEntry.Text
                });

            }
            else {
                recipe.IngredientsCollection.Add(new IngredientModel {
                    Amount = numAmount,
                    Measurement = $"{formattedMeasurement}s",
                    Ingredient = IngredientsEntry.Text
                });

            }

            AmountPicker.SelectedItem = AmountPicker.Title;
            MeasurmentPicker.SelectedItem = MeasurmentPicker.Title;
            IngredientsEntry.Text = string.Empty;

        }

    }

    private double NumConverter(string selectedItem) {
        
        if (selectedItem.Contains("/")) {

            return double.Parse(selectedItem.Substring(0, 1)) / double.Parse(selectedItem.Substring(selectedItem.Length - 1, 1));

        }

        return double.Parse(selectedItem);

    }

    private void AddDirectionsButton_Clicked(object sender, EventArgs e) {

        if (string.IsNullOrWhiteSpace(DirectionsEntry.Text)) {

            DisplayAlert("No Direction Entered", "Please enter a direction.", "OK");

        }
        else {

            recipe.DirectionsCollection.Add(DirectionsEntry.Text);
            DirectionsEntry.Text = string.Empty;

        }

    }

    private async void AddRecipeButton_Clicked(object sender, EventArgs e) {

        if (string.IsNullOrWhiteSpace(RecipeNameEntry.Text)) {

            await DisplayAlert("No Recipe Name", "Please enter a Recipe Name.", "OK");

        }
        else if (recipe.IngredientsCollection.Count == 0) {

            await DisplayAlert("No Ingredients", "Please enter some Ingredients.", "OK");

        }
        else if (recipe.DirectionsCollection.Count == 0) {

            await DisplayAlert("No Directions", "Please enter some Directions.", "OK");

        }
        else {

            recipe.RecipeName = RecipeNameEntry.Text;
            // TODO - Add new recipe to a DataBase
            await Navigation.PopAsync();

        }

    }

    private async void CancelAddRecipeButton_Clicked(object sender, EventArgs e) {

        bool answer = await DisplayAlert("Are you sure?", "Are you sure you want to cancel? Progress for this recipe will not be saved.", "Yes", "No");

        if (answer) {
            await Navigation.PopAsync();
        }

    }

}