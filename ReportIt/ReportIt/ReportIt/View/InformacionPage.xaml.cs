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
    public partial class InformacionPage : ContentPage
    {
        public InformacionPage()
        {
            InitializeComponent();
        }

        private void BtnleerIntrafamiliar_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.asamblea.gob.sv/sites/default/files/documents/decretos/6D51278E-3A85-44B3-97A9-EDC89A534E00.pdf"));
        }

        private void BtnleerCodigoPenal_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.asamblea.gob.sv/sites/default/files/documents/decretos/C0AB56F8-AF37-4F25-AD90-08AE401C0BA7.pdf"));
        }

        private void BtnleerLepina_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.asamblea.gob.sv/sites/default/files/documents/decretos/F312B814-45C5-48EB-A71D-0DFC612FF135.pdf"));
        }
    }
}