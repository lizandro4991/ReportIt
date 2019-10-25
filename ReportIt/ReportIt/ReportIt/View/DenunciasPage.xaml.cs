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
    public partial class DenunciasPage : ContentPage
    {
        public DenunciasPage()
        {
            InitializeComponent();
            BindingContext = new Model.DenunciaModel();
        }

        private async void BtnDenunciar_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TxtNombre.Text) || String.IsNullOrWhiteSpace(TxtDireccion.Text) || String.IsNullOrWhiteSpace(TxtTipoViolencia.Text) || String.IsNullOrWhiteSpace(TxtDescripcion.Text))
            {
                await DisplayAlert("Info", "Llenar Todos Los Campos", "Ok");
            }
            else
            {
                var ListaDenuncias = (Model.DenunciaModel)BindingContext;
                //Insertar un Registro.
                var Resultado = await App.DataBase.InsertarDenuncia(ListaDenuncias);

                if (Resultado == 1)
                {
                    await App.Current.MainPage.DisplayAlert("Info", $"Registro guardado con Exito", "OK");
                    await Navigation.PopAsync();
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Info", "Error al Guardar", "OK");
                    await Navigation.PopAsync();
                }
            }
        }
    }
}