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
            GoToSomePage();
        }

        private void OnSwiped(object sender, SwipedEventArgs e)
        {
            GoToSomePage();
        }

        void GoToSomePage()
        {
            Shell.Current.GoToAsync("LoginPage");
        }
    }
}