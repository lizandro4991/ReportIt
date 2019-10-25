using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReportIt.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdministracionPage : ContentPage
    {
        List<Model.DenunciaModel> Tareas = new List<Model.DenunciaModel>();
        public AdministracionPage()
        {
            InitializeComponent();
        }


        private async void ListViewItem_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var TodasDenuncias = e.SelectedItem as Model.DenunciaModel;
            if (TodasDenuncias != null)
            {
                await Navigation.PushAsync(new AdministracionModificarPage { BindingContext = TodasDenuncias });
            }
        }

        async void OnContactAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PrincipalPage());
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            var R = new Model.DenunciaProcesos();
            var Result = R.ObtenerTodasDenuncias();
            var r = await Result;
            Tareas = r.ToList();
            ListViewItem.ItemsSource = Tareas;
        }
    }
}