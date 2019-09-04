using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XrnCourse.ExploreUI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabsExamplePage : TabbedPage
    {
        public TabsExamplePage()
        {
            InitializeComponent();
        }
        private void BtnFirstTab_Clicked(object sender, EventArgs e)
        {
            CurrentPage = this.Children[0];
        }
    }
}