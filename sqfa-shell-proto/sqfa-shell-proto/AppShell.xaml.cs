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
            // Make sure it's safe to examine the current page
            if ((Shell.Current != null) &&
                (Shell.Current.CurrentPage != null))
            {
                Console.WriteLine($"{e.Source} {Shell.Current.Title}");
                if (
                    // Detect Back Navigation
                    e.Source == ShellNavigationSource.Pop &&

                    // Cancel or Not, based on (for example) the Title of the current page.
                    (Shell.Current.Title != "My Main Page"))
                {
                    e.Cancel();
                    Shell.Current.GoToAsync("..");
                }
            }
            base.OnNavigating(e);
        }
    }
}
