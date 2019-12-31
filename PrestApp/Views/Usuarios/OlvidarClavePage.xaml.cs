using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using PrestApp.Shared.Views.Informations;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrestApp.Shared.Views.Usuarios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OlvidarClavePage : PopupPage
    {
        public OlvidarClavePage()
        {
            InitializeComponent();
        }
        [Obsolete]
        private async void btnRegistroNuevaClave_Clicked(object sender, EventArgs e)
        {
            LoadingGeneralPage cargando = new LoadingGeneralPage();
            
            await PopupNavigation.PushAsync(cargando);
            await Task.Delay(2500);

            if (txtNombreClaveNueva.Text == "Nadia" && txtApellidoClaveNueva.Text == "Disla" && 
                txtClaveNueva.Text == "2323" && txtClaveNueva.Text == txtConfirmarClaveNueva.Text)
            {

                await Navigation.PushAsync(new GeneralLoginPage());
                await PopupNavigation.RemovePageAsync(cargando);
                await PopupNavigation.RemovePageAsync(this);
                CambioClaveValid cambioGuardado = new CambioClaveValid();
                await PopupNavigation.PushAsync(cambioGuardado);
            }
        }
    }
}