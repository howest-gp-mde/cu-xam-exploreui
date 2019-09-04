using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XrnCourse.ExploreUI.MasterDetailViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExampleMasterPage : ContentPage
    {
        public ListView ListView;

        public ExampleMasterPage()
        {
            InitializeComponent();

            BindingContext = new ExampleMasterPageModel();
            ListView = MenuItemsListView;
        }

    }
}