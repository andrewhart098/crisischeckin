using CrisisCheckinMobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CrisisCheckinMobile.Views
{
    public partial class ProfileView : ContentPage
    {
        public ProfileView()
        {
            InitializeComponent();
            BindingContext = new ProfileViewModel(this.Navigation);
            this.Title = "Home";

            Content =
                new TableView
                {
                    Root = new TableRoot
                    {
                        new TableSection("Settings")
                        {
                            new EntryCell {Text = "New Voice Mail"},
                            new EntryCell {Text = "New Mail"}
                        }
                    },
                    Intent = TableIntent.Settings
                };
        }
    }
}
