using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XrnCourse.ExploreUI.LayoutPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackLayoutPage : ContentPage
    {
        public StackLayoutPage()
        {
            InitializeComponent();
        }

        private void SliderA_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            txtSliderA.Text = sliderA.Value.ToString("N0");
        }

        private void TxtSliderA_Completed(object sender, EventArgs e)
        {
            int sliderVal = 0;
            if (int.TryParse(txtSliderA.Text, out sliderVal))
                sliderA.Value = sliderVal;
            else
                txtSliderA.Text = sliderA.Value.ToString("N0");
        }
    }
}