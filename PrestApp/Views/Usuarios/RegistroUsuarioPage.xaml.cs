using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestApp.Shared.Views.Informations;
using PrestApp.Shared.Views.Usuarios;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Services;

namespace PrestApp.Shared.Views.Usuarios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroUsuarioPage : ContentPage
    {
        public RegistroUsuarioPage()
        {
            InitializeComponent();
        }

        [Obsolete]
        private async void btnRegistroUsuario_Clicked(object sender, EventArgs e)
        {
            LoadingRegistroPage loadingPage = new LoadingRegistroPage();
            RegisterInformationValid validRegistro = new RegisterInformationValid();
            await PopupNavigation.PushAsync(loadingPage);
            await Task.Delay(2500);
            if (txtNombres.Text == "Nadia María" && txtApellidos.Text == "Disla Tejada"
                && txtClaveRegistro.Text == "1234" && txtConfirmarClaveRegistro.Text == txtClaveRegistro.Text)
            {
                await Navigation.PushAsync(new GeneralLoginPage());
                await PopupNavigation.RemovePageAsync(loadingPage);
                await PopupNavigation.PushAsync(validRegistro);
                await Task.Delay(2000);
            }

        }
    }
}