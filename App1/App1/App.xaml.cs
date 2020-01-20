using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using AppInformeGranjas.DataBase;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace App1
{
    public partial class App : Application
    {
        static DataBaseMort database;

        public static DataBaseMort Database
        {
            get
            {
                if (database == null)
                {
                    database = new DataBaseMort(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

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
