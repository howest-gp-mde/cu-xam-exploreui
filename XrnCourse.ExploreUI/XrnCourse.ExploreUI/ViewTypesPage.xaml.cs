using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XrnCourse.ExploreUI.ViewTypePages;

namespace XrnCourse.ExploreUI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewTypesPage : ContentPage
    {
        public ViewTypesPage()
        {
            InitializeComponent();
        }

        private async void BtnGoBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void BtnTextualView_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TextualViewsPage());
        }
    }
}