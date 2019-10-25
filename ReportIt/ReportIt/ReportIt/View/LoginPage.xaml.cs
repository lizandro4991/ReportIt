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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Clicked(object sender, EventArgs e)
        {
            string user = EntUsuario.Text;
            string pass = EntPass.Text;
            if (user == "a" && pass == "a")
            {
                Navigation.PushAsync(new AdministracionPage());
            }
            else
            {
                DisplayAlert("Error", "Credenciales Invalidas", "Ok");
            }
        }

    }
}