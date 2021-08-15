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
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            Shell.Current.FlyoutIsPresented = false;
            await Shell.Current.GoToAsync("//LoginPage");
        }

        protected override void OnNavigating(ShellNavigatingEventArgs e)
        {
            if((Shell.Current != null) && (Shell.Current.CurrentPage != null))
            {
                switch (Shell.Current.CurrentPage.Title)
                {
                    case "Do Something":
                        switch (e.Source)
                        {
                            case ShellNavigationSource.Pop:
                                e.Cancel();
                                Device.BeginInvokeOnMainThread(() =>
                                {
                                    App.Current.MainPage.DisplayAlert(
                                        "Correct!",
            @"That's the right answer!

The system back button
is OURS now!",
                                        "Got it!");
                                    Shell.Current.GoToAsync("//AboutPage");
                                });
                                break;
                            case ShellNavigationSource.Unknown:
                            case ShellNavigationSource.Push:
                            case ShellNavigationSource.PopToRoot:
                            case ShellNavigationSource.Insert:
                            case ShellNavigationSource.Remove:
                            case ShellNavigationSource.ShellItemChanged:
                            case ShellNavigationSource.ShellSectionChanged:
                            case ShellNavigationSource.ShellContentChanged:
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
            base.OnNavigating(e);

        }
    }
}
