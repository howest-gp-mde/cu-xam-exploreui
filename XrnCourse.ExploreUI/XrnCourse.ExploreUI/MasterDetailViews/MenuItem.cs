using System;

namespace XrnCourse.ExploreUI.MasterDetailViews
{
    public class MasterDetailExamplePageMenuItem
    {
        public MasterDetailExamplePageMenuItem()
        {
            TargetType = typeof(ExampleDetailPage);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public bool ShowButton { get; set; }

        public Type TargetType { get; set; }
    }
}
