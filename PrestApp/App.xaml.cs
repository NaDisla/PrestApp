using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PrestApp.Shared.Views.Usuarios;

namespace PrestApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new GeneralLoginPage());
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
