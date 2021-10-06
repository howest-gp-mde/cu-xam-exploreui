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

            Application.Current.ModalPopped += Current_ModalPopped; ;
        }

        ~PageTypesPage()
        {
            Application.Current.ModalPopped -= Current_ModalPopped; ;
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

        private async void BtnModalPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ModalExamplePage());
        }

        private async void Current_ModalPopped(object sender, ModalPoppedEventArgs e)
        {
            var modalExamplePage = e.Modal as ModalExamplePage;
            await DisplayAlert("You age", $"You told us you are {modalExamplePage.TxtAge.Text} years old", "I know.");
        }

    }
}