using sqfa_shell_proto.ViewModels;
using sqfa_shell_proto.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace sqfa_shell_proto
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            Shell.Current.FlyoutIsPresented = false;
            await Shell.Current.GoToAsync("//MainPage/LoginPage");
        }

        protected override void OnNavigating(ShellNavigatingEventArgs e)
        {
            if(
                e.Source == ShellNavigationSource.Pop &&
                (Shell.Current != null) && 
                (Shell.Current.CurrentPage != null) &&
                (Shell.Current.Title != "My Main Page"))
            {
                e.Cancel();
                Shell.Current.GoToAsync("..");
            }
            base.OnNavigating(e);
        }
    }
}
