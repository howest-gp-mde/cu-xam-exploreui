using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XrnCourse.ExploreUI.MasterDetailViews
{

    internal class ExampleMasterPageModel : INotifyPropertyChanged
    {
        public ObservableCollection<MasterDetailExamplePageMenuItem> MenuItems { get; set; }

        public ExampleMasterPageModel()
        {
            MenuItems = new ObservableCollection<MasterDetailExamplePageMenuItem>(new[]
            {
                    new MasterDetailExamplePageMenuItem { Id = 0, Title = "Page 1" },
                    new MasterDetailExamplePageMenuItem { Id = 1, Title = "Page 2" },
                    new MasterDetailExamplePageMenuItem { Id = 2, Title = "Page 3" },
                    new MasterDetailExamplePageMenuItem { Id = 3, Title = "Page 4" },
                    new MasterDetailExamplePageMenuItem { Id = 4, Title = "Page 5" },
                });
        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
