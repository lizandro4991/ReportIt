using ReportIt.Model;
using ReportIt.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReportIt
{
    public partial class App : Application
    {
        public static DenunciaProcesos DataBase = new DenunciaProcesos();
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PrincipalPage());
            var navigationPage = App.Current.MainPage as NavigationPage;
            navigationPage.BarBackgroundColor = Color.FromHex("#33578F");
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
