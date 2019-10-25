using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReportIt.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactosPage : ContentPage
    {
        public ContactosPage()
        {
            InitializeComponent();
        }

        private async void BtnPolicia_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Info", "Seguro Desea Llamar", "Ok", "Cancel");
            // since we are using async, we should specify the DisplayAlert as awaiting.
            if (result == true) // if it's equal to Ok
            {
                try
                {
                    PhoneDialer.Open("911");
                }
                catch (Exception)
                {
                    // Other error has occurred.
                }
            }
            else // if it's equal to Cancel
            {
                return; // just return to the page and do nothing.
            }


        }

        private async void Btnisdemu_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Info", "Seguro Desea Llamar", "Ok", "Cancel");
            if (result == true) // if it's equal to Ok
            {
                try
                {
                    PhoneDialer.Open("25104100");
                }
                catch (Exception)
                {
                    // Other error has occurred.
                }
            }
            else // if it's equal to Cancel
            {
                return; // just return to the page and do nothing.
            }

        }

        private async void BtnIsna_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Info", "Seguro Desea Llamar", "Ok", "Cancel");
            if (result == true) // if it's equal to Ok
            {
                try
                {
                    PhoneDialer.Open("75932080");
                }

                catch (Exception)
                {
                    // Other error has occurred.
                }
            }
            else // if it's equal to Cancel
            {
                return; // just return to the page and do nothing.
            }

        }
    }
}