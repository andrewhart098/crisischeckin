using CrisisCheckinMobile.Pages;
using Xamarin.Forms;

namespace CrisisCheckinMobile.Views
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            BackgroundColor = Color.White;
            var navigationPage = new NavigationPage(new ProfileView());
            navigationPage.Title = "Home";
            navigationPage.Icon = "Images/home_7.png";
            navigationPage.BarBackgroundColor = Constants.HtBoxRed;

            Children.Add(navigationPage);
            Children.Add(new ResourceListPage()
            {
                Title = "Resources",
                Icon = "Images/checklist_7.png"
            });

            Children.Add(new MyRequests()
            {
                Title = "Requests",
                Icon = "Images/check_7.png"
            });

            Children.Add(new TemporaryView()
            {
                Title = "Report",
                Icon = "Images/eye_7.png"
            });


        }
    }
}
