using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XrnCourse.ExploreUI.LayoutPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsoluteLayoutPage : ContentPage
    {
        public AbsoluteLayoutPage()
        {
            InitializeComponent();
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            boxPlayer.TranslationX -= 10;
        }

        private void BtnTop_Click(object sender, EventArgs e)
        {
            boxPlayer.TranslationY -= 10;
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            boxPlayer.TranslationX += 10;
        }

        private void BtnBottom_Click(object sender, EventArgs e)
        {
            boxPlayer.TranslationY += 10;
        }
    }
}