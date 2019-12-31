using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PrestApp.Shared.Views.Usuarios;
using PrestApp.Shared.Views.Prestamista;

namespace PrestApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MasterPrestamistaPage());
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
