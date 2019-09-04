using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XrnCourse.ExploreUI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageTypesPage : ContentPage
    {
        public PageTypesPage()
        {
            InitializeComponent();
        }

        private async void BtnNavigationPage_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Navigation page?",
                @"Guess what..
You're using a navigation page right now!

Just click one of the buttons below and watch it happen.",
                "A'ight");
        }

        private async void BtnTabbedPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabsExamplePage());
        }

        private async void BtnMasterDetailPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MasterDetailExamplePage());
        }

        private async void BtnGoBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

    }
}