using RecipeBookLibrary.ViewModels;

namespace RecipeBook {
    public partial class MainPage : ContentPage {
        int count = 0;

        public MainPage() {
            InitializeComponent();
            BindingContext = new RecipeViewModel();
        }

        private void AddNewRecipeButton_Clicked(object sender, EventArgs e) {

            App.Current.MainPage = new NavigationPage(new AddNewRecipePage());

        }
    }
}
