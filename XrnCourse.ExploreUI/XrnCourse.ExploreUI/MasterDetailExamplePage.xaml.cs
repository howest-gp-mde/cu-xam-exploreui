using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XrnCourse.ExploreUI.MasterDetailViews;

namespace XrnCourse.ExploreUI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailExamplePage : MasterDetailPage
    {
        public MasterDetailExamplePage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterDetailExamplePageMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}