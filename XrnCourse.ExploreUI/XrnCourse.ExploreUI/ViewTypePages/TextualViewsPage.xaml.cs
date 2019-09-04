using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XrnCourse.ExploreUI.ViewTypePages
{
    [XamlCompilation(XamlCompilationOptions.Skip)]
    public partial class TextualViewsPage : ContentPage
    {
        public TextualViewsPage()
        {
            InitializeComponent();

            lblSmallNamed.FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label));
        }

        private void TxtChat_Completed(object sender, EventArgs e)
        {
            string text = txtChat.Text ?? "";
            txtReverseChat.Text = new string(text.ToCharArray().Reverse().ToArray());
        }

        private void TxtChat_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = e.NewTextValue ?? "";
            lblNumberChars.Text = $"{text.Length} chars";
        }
    }
}