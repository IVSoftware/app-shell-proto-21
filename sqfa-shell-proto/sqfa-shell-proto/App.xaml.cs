using sqfa_shell_proto.Services;
using sqfa_shell_proto.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sqfa_shell_proto
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
