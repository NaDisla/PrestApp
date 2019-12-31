using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PrestApp.Shared.Views.Informations;
using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using PrestApp.Shared.Views.Prestamista;

namespace PrestApp.Shared.Views.Usuarios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneralLoginPage : ContentPage
    {
        private bool clicked = false;
        public GeneralLoginPage()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistroUsuarioPage());
        }

        //[Obsolete]
        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            /*LoadingGeneralPage loadingPage = new LoadingGeneralPage();
            await PopupNavigation.PushAsync(loadingPage);
            await Task.Delay(3000);
            if(txtUsuario.Text == "nadia" && txtClave.Text == "1234")
            {
                await Navigation.PushAsync(new RegistroUsuarioPage());
                await PopupNavigation.RemovePageAsync(loadingPage);
            }*/

            Navigation.PushAsync(new MasterPrestamistaPage());

        }

        [Obsolete]
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            OlvidarClavePage olvidarClave = new OlvidarClavePage();
            await PopupNavigation.PushAsync(olvidarClave);
            
        }
    }
}