using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using AppInformeGranjas.Models;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace App1
{
    public partial class App : Application
    {
        public App(String filename)
        {
            InitializeComponent();

            UserRepository.Inicializador(filename);
            MainPage = new NavigationPage(new AppInformeGranjas.SplashPage());

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
