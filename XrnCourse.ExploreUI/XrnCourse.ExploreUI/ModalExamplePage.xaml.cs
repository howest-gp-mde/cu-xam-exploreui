using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XrnCourse.ExploreUI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalExamplePage : ContentPage
    {
        public ModalExamplePage()
        {
            InitializeComponent();
        }

        private async void BtnOk_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtAge.Text))
            {
                await DisplayAlert("Error", "Please enter your age!", "OK then");
            }
            else
            {
                await Navigation.PopModalAsync();
            }
            
        }
    }
}