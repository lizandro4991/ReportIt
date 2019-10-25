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
    public partial class AdministracionModificarPage : ContentPage
    {
        public AdministracionModificarPage()
        {
            InitializeComponent();
        }

        private async void BtnActualizar_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Actualizar", "Seguro Desea Actializar", "Ok", "Cancel");
            // since we are using async, we should specify the DisplayAlert as awaiting.
            if (result == true) // if it's equal to Ok
            {
                var ContactoUpdate = (Model.DenunciaModel)BindingContext;

                await App.DataBase.ActualizarDenuncia(ContactoUpdate);
                await Navigation.PopAsync();
            }
            else // if it's equal to Cancel
            {
                return; // just return to the page and do nothing.
            }


        }

        private async void BtnResuelto_Clicked(object sender, EventArgs e)
        {
            var resulta = await DisplayAlert("Actualizar", "Seguro Desea Eliminar", "Ok", "Cancel");
            // since we are using async, we should specify the DisplayAlert as awaiting.
            if (resulta == true) // if it's equal to Ok
            {
                var ContactoDelete = (Model.DenunciaModel)BindingContext;

                await App.DataBase.BorrarDenuncia(ContactoDelete);
                await Navigation.PopAsync();
            }
            else // if it's equal to Cancel
            {
                return; // just return to the page and do nothing.
            }


        }
    }
}