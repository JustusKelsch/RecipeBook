﻿namespace RecipeBook {
    public partial class AppShell : Shell {
        public AppShell() {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(AddNewRecipePage), typeof(AddNewRecipePage));
        }
    }
}
