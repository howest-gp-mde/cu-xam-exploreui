using Xamarin.Forms;

namespace XrnCourse.ExploreUI
{
    public partial class App : Application
    {
        public App()
        {
            AdMaiora.RealXaml.Client.AppManager.Init(this);
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
