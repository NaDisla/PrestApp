using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestApp.Shared.Views.Prestamista.Prestamos;
using PrestApp.Shared.Views.Prestamista.Pagos;
using PrestApp.Shared.Views.Prestamista.Amortizaciones;
using PrestApp.Shared.Views.Prestamista.Clientes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrestApp.Shared.Views.Prestamista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPrestamistaPage : MasterDetailPage
    {
        public List<MasterPrestamistaItem> listadoMenu
        {
            get;
            set;
        }
        public MasterPrestamistaPage()
        {
            InitializeComponent();

            listadoMenu = new List<MasterPrestamistaItem>();

            MasterPrestamistaItem page = new MasterPrestamistaItem()
            {
                saludoUsuario = "Hola, Usuario",
                imagenUsuario = "usuario.png",
                pageDestination = typeof(PrestamistaHomePage)
            };
            listadoMenu.Add(page);

            page = new MasterPrestamistaItem()
            {
                Nombre = "Inicio",
                Imagen = "inicio.png",
                pageDestination = typeof(PrestamistaHomePage)
            };
            listadoMenu.Add(page);

            page = new MasterPrestamistaItem()
            {
                Nombre="Préstamos",
                Imagen = "prestamos.png",
                pageDestination = typeof(PrestamosHomePage)
            };
            listadoMenu.Add(page);

            page = new MasterPrestamistaItem()
            {
                Nombre = "Pagos",
                Imagen = "pagos.png",
                pageDestination = typeof(PagosHomePage)
            };
            listadoMenu.Add(page);

            page = new MasterPrestamistaItem()
            {
                Nombre = "Clientes",
                Imagen = "clientes.png",
                pageDestination = typeof(ClientesHomePage)
            };
            listadoMenu.Add(page);

            page = new MasterPrestamistaItem()
            {
                Nombre = "Amortizaciones",
                Imagen = "amortizacion.png",
                pageDestination = typeof(AmortizacionesHomePage)
            };
            listadoMenu.Add(page);

            listaElementosMenuPrestamista.ItemsSource = listadoMenu;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(PrestamistaHomePage)));
        }

        private void listaElementosMenuPrestamista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MasterPrestamistaItem pagina = e.SelectedItem as MasterPrestamistaItem;
            Detail = new NavigationPage((Page)Activator.CreateInstance(pagina.pageDestination));
            
            IsPresented = false;
        }
    }
}