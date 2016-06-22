using CrisisCheckinMobile.Pages;
using Xamarin.Forms;

namespace CrisisCheckinMobile.Views
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            BackgroundColor = Color.White;


            var homePage = new NavigationPage(new ProfileView());
            homePage.Title = "Home";
            homePage.Icon = "Images/home_7.png";
            homePage.BarBackgroundColor = Constants.HtBoxRed;
            homePage.BarTextColor = Color.White;
            Children.Add(homePage);

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
