using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XrnCourse.ExploreUI.LayoutPages;

namespace XrnCourse.ExploreUI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LayoutTypesPage : ContentPage
    {
        public LayoutTypesPage()
        {
            InitializeComponent();
        }

        private async void BtnGoBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void BtnStackLayout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayoutPage());
        }

        private async void BtnGridLayout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridLayoutPage());
        }

        private async void BtnAbsoluteLayout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsoluteLayoutPage());
        }

        private async void BtnRelativeLayout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RelativeLayoutPage());
        }

        private async void BtnFrames_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FrameLayoutPage());
        }

        private async void BtnFlexLayout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FlexLayoutPage());
        }
    }
}