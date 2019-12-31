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

            //Master = this;
            //Detail = this;
            listadoMenu = new List<MasterPrestamistaItem>();

            MasterPrestamistaItem page1 = new MasterPrestamistaItem()
            {
                Nombre = "Inicio",
                Imagen = "inicio.png",
                pageDestination = typeof(PrestamistaHomePage)
            };
            listadoMenu.Add(page1);

            MasterPrestamistaItem page2 = new MasterPrestamistaItem()
            {
                Nombre="Préstamos",
                Imagen = "prestamos.png",
                pageDestination = typeof(PrestamosHomePage)
            };
            listadoMenu.Add(page2);

            MasterPrestamistaItem page3 = new MasterPrestamistaItem()
            {
                Nombre = "Pagos",
                Imagen = "pagos.png",
                pageDestination = typeof(PagosHomePage)
            };
            listadoMenu.Add(page3);

            MasterPrestamistaItem page4 = new MasterPrestamistaItem()
            {
                Nombre = "Clientes",
                Imagen = "clientes.png",
                pageDestination = typeof(ClientesHomePage)
            };
            listadoMenu.Add(page4);

            MasterPrestamistaItem page5 = new MasterPrestamistaItem()
            {
                Nombre = "Amortizaciones",
                Imagen = "amortizaciones.png",
                pageDestination = typeof(AmortizacionesHomePage)
            };
            listadoMenu.Add(page5);
        }

        private void listaElementosMenuPrestamista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MasterPrestamistaItem pagina = e.SelectedItem as MasterPrestamistaItem;
            Detail = new NavigationPage((Page)Activator.CreateInstance(pagina.pageDestination));
            IsPresented = false;
        }
    }
}