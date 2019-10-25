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
    public partial class PrincipalPage : ContentPage
    {
        public PrincipalPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void ibtnAdmin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

        private void ibtnDenuncia_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DenunciasPage());
        }

        private void ibtnInfo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InformacionPage());
        }

        private void ibtnContactos_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactosPage());
        }
    }
}