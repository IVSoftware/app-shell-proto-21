using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sqfa_shell_proto.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            
        }

        private void OnTapped(object sender, EventArgs e)
        {
            App.Current.MainPage.DisplayAlert("", "And I said, \"sure\".", "Do Something");
            Shell.Current.GoToAsync("//LoginPage");
        }

        private void OnSwiped(object sender, SwipedEventArgs e)
        {
            App.Current.MainPage.DisplayAlert("", "Got you swipers covered, too", "Do Something");
            Shell.Current.GoToAsync("//LoginPage");
        }
    }
}