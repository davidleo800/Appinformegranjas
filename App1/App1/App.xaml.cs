using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using AppInformeGranjas.DataBase;
using AppInformeGranjas.Login;
using App1;
using AppInformeGranjas;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace App1
{
    public partial class App : Application, ILoginManager
    {
        static DataBaseMort database;
        static ILoginManager loginManager;
        public static App Current;
        public static int val;

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

            MainPage = new NavigationPage(new AppInformeGranjas.SplashPage())

            Current = this;
            var isLoggedIn = Properties.ContainsKey("IsLoggedIn") ? (bool)Properties["IsLoggedIn"] : false;
            if (isLoggedIn)
                
                MainPage = new Inicio();
            else
                MainPage = new LoginModalPage(this);

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

        public void ShowMainPage()
        {
            MainPage = new DetailMain();
        }

        public void Logout()
        {
            Properties["IsLoggedIn"] = false;
            MainPage = new  LoginModalPage(this);
        }
    }
}
