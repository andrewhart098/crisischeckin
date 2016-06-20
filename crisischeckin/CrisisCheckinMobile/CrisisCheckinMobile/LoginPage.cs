using CrisisCheckinMobile.Views;
using System;
using Xamarin.Forms;

namespace CrisisCheckinMobile
{
    public class LoginPage : ContentPage
    {
        private readonly Button _loginButton;
        private readonly Button _registerButton;

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            //...
            var isValid = true; //AreCredentialsCorrect (user);
            if (isValid)
            {
                //App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new ProfileView(), this);
                await Navigation.PopAsync();
            }
            else
            {
                // Login failed
            }
        }

        public LoginPage()
        {
            _loginButton = new Button
            {
                Text = "Login",
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            _loginButton.Clicked += OnLoginButtonClicked;

            _registerButton = new Button
            {
                Text = "Register",
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            _registerButton.Clicked += OnRegistrationButtonClicked;

            BackgroundColor = Constants.HtBoxDarkBrown;
            Title = "Crisis Checkin Login";
            Content = new StackLayout
            { 
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand,
                Padding = new Thickness(10, 100, 10, 20),
                WidthRequest = 280.0,
                Children =
                {
                    new Entry
                    {
                        Placeholder = "Username",
                        HorizontalTextAlignment = TextAlignment.Start,
                        WidthRequest = 280.0
                    },
                    new Entry
                    {
                        Placeholder = "Password",
                        HorizontalTextAlignment = TextAlignment.Start,
                        IsPassword = true,
                        WidthRequest = 280.0
                    },

                    new StackLayout()
                    {
                        Orientation = StackOrientation.Horizontal,
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        Spacing = 60.0,
                        Children =
                        {
                            _loginButton,
                            _registerButton
                        }
                    }
                    
                }
            };
        }

        ~LoginPage()
        {
            if (_loginButton != null)
            {
                _loginButton.Clicked -= OnLoginButtonClicked;
            }
            if (_registerButton != null)
            {
                _registerButton.Clicked -= OnRegistrationButtonClicked;
            }
        }

        private async void OnRegistrationButtonClicked(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new RegistrationPage(), this);
            await Navigation.PopAsync();
        }
    }
}